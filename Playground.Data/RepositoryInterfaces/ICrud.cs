namespace Playground.Data.RepositoryInterfaces
{
    interface ICrud<T>
    {
        T Get(int Id);
        bool Create(T item);
        bool Update(int id, T item);
        bool Delete(int Id);
    }
}
