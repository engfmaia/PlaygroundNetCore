using System.Collections.Generic;
using System.Linq;

namespace Playground.Data.RepositoryInterfaces
{
    interface ISearchable<T>
    {
        IQueryable<T> Get(IEnumerable<int> Ids);
        IQueryable<T> GetPaginated(int page, int numberOfItems, bool desc = false);
    }
}
