using Agenda.Models;

namespace Agenda.Repository.Iterfaces
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        T Insert(T entity);
        T Update(T entity);
        void Delete(int id);
    }
}
