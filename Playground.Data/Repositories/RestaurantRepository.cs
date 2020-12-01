using Playground.Business.Domain.Models.Restaurant;
using Playground.Data.RepositoryInterfaces;
using System.Collections.Generic;
using System.Linq;

namespace Playground.Data.Repositories
{
    public class RestaurantRepository : ICrud<Restaurant>, ISearchable<Restaurant>
    {
        public Restaurant Get(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Restaurant> Get(IEnumerable<int> Ids)
        {
            throw new System.NotImplementedException();
        }

        public bool Create(Restaurant item)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int Id)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<Restaurant> GetPaginated(int page, int numberOfItems,  bool desc = false)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(int id, Restaurant item)
        {
            throw new System.NotImplementedException();
        }
    }
}
