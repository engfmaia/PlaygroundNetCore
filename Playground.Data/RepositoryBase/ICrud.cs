using System.Threading.Tasks;

namespace Playground.Data.RepositoryBase
{
    public interface ICrud<T>
    {
        void Create(T entity);
        Task<T> ReadAsync(int id);
        void Update(T entity);
        void Delete(T entity);
    }
}
