using System;
using System.Linq;
using System.Linq.Expressions;

namespace Playground.Data.RepositoryBase
{
    public interface ISearchable<T>
    {
        IQueryable<T> FindAll();
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
    }
}
