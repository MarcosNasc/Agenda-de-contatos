using Agenda.Data;
using Agenda.Iterfaces;
using Agenda.Models;
using Microsoft.EntityFrameworkCore;

namespace Agenda.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : Entity
    {
        private readonly AgendaContext _context;
        private DbSet<T> _table;

        public GenericRepository(AgendaContext context)
        {
            _context = context;
            _table = _context.Set<T>();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var entities = await _table.ToListAsync();
            return entities;
        }

        public async Task<T> Get(int id)
        {
            T entity =  GetById(id);
            return entity;
        }

        public async Task<T> Insert(T entity)
        {
            _table.Add(entity);
            Save();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
           _context.SaveChanges();
            return entity;
        }

        public async void Delete(int id)
        {
            T entity =  GetById(id);
            if (entity != null)
            {
                _table.Remove(entity);
                Save();
            }
        }

        private T GetById(int id)
        {
            var entity =  _table.FirstOrDefault(it => it.Id == id);
            return entity;
        }

        private void Save()
        {
            _context.SaveChangesAsync();
        }
    }
}
