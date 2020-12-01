using Playground.Business.Domain.Models.Restaurant;
using Playground.Data.RepositoryBase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playground.Data.Repositories.Restaurants
{
    public interface IRestaurantRepository : IRepositoryBase<Restaurant>
    {
        Task<IEnumerable<Restaurant>> GetAllRestaurantsAsync();
        Task<Restaurant> GetRestaurantByIdAsync(int restaurantId);
    }
}
