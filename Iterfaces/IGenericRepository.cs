using Agenda.Models;

namespace Agenda.Iterfaces
{
    public interface IGenericRepository<T> where T : Entity
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(int id);
        Task<T> Insert(T entity);
        Task<T> Update(T entity);
        void Delete(int id);
    }
}
