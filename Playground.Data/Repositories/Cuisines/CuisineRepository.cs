using Microsoft.EntityFrameworkCore;
using Playground.Business.Domain.Models.Restaurant;
using Playground.Data.DbContext;
using Playground.Data.RepositoryBase;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Playground.Data.Repositories.Cuisines
{
    public class CuisineRepository : RepositoryBase<CuisineType>, ICuisineRepository
    {

        public CuisineRepository(PlaygroundDbContext playgroundDbContext)
            :base(playgroundDbContext)
        {
        }

        public async Task<IEnumerable<CuisineType>> GetAllCuisineTypeAsync()
        {
            return await FindAll().OrderBy(x => x.Name).ToListAsync();
        }

        public async Task<IEnumerable<Restaurant>> GetRestaurantsCuisineTypeIdAsync(int cuisineTypeId)
        {
            var cuisine = await FindByCondition(x => x.Id.Equals(cuisineTypeId)).FirstOrDefaultAsync();
            return cuisine.Restaurants;
        }
    }
}
