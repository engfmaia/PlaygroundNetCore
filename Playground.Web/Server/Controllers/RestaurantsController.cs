using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Playground.Data.Repositories.Restaurants;
using System;
using System.Threading.Tasks;

namespace Playground.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantsController : ControllerBase
    {
        private readonly IRestaurantRepository _restaurantRepository;
        private readonly ILogger _logger;

        public RestaurantsController(IRestaurantRepository restaurantRepository, ILogger<RestaurantsController> logger)
        {
            _restaurantRepository = restaurantRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var restaurants = await _restaurantRepository.GetAllRestaurantsAsync();
                _logger.LogInformation($"Returned all restaurants from database.");

                return Ok(restaurants);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Get restaurantes action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }

        }
    }
}
