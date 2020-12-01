using Microsoft.EntityFrameworkCore;
using Playground.Business.Domain.Models.Restaurant;
using Playground.Data.DbContext;
using Playground.Data.RepositoryBase;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Data.Repositories.Restaurants
{
    public class RestaurantRepository : RepositoryBase<Restaurant>, IRestaurantRepository
    {

        public RestaurantRepository(PlaygroundDbContext playgroundDbContext)
            :base(playgroundDbContext)
        {
        }

        public async Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync()
        {
            return await FindAll().OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<Restaurant> GetRestaurantByIdAsync(int restaurantId)
        {
            return await FindByCondition(x => x.Id.Equals(restaurantId)).FirstOrDefaultAsync();
        }
    }
}
