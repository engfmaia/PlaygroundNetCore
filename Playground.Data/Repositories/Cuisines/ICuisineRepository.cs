using Playground.Business.Domain.Models.Restaurant;
using Playground.Data.RepositoryBase;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Playground.Data.Repositories.Cuisines
{
    public interface ICuisineRepository : IRepositoryBase<CuisineType>
    {
        Task<IEnumerable<CuisineType>> GetAllCuisineTypeAsync();
        Task<IEnumerable<Restaurant>> GetRestaurantsCuisineTypeIdAsync(int cuisineTypeId);
    }
}
