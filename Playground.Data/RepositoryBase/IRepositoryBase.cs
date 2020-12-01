namespace Playground.Data.RepositoryBase
{
    public interface IRepositoryBase<T> : ICrud<T>, ISearchable<T>, ISave
    {
    }
}
