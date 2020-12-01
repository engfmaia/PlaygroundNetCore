using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Playground.Business.Domain.Models.Restaurant;
using Playground.Data.Repositories.Cuisines;
using System;
using System.Threading.Tasks;

namespace Playground.Web.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CuisineTypesApiController : ControllerBase
    {
        private readonly ICuisineRepository _cuisineTypesRepository;
        private readonly ILogger _logger;

        public CuisineTypesApiController(ICuisineRepository cuisineTypesRepository, ILogger<RestaurantsController> logger)
        {
            _cuisineTypesRepository = cuisineTypesRepository;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var cuisineTypes = await _cuisineTypesRepository.GetAllCuisineTypeAsync();
                _logger.LogInformation($"Returned all cuisines from database.");

                return Ok(cuisineTypes);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Get cuisineTypes action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post(CuisineType cuisineType)
        {
            try
            {
                _cuisineTypesRepository.Create(cuisineType);
                await _cuisineTypesRepository.SaveAsync();
                _logger.LogInformation($"Create cuisine type in database.");

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Post cuisineTypes action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var cuisine = await _cuisineTypesRepository.ReadAsync(id);
                if (cuisine != null)
                {
                    _cuisineTypesRepository.Delete(cuisine);
                    await _cuisineTypesRepository.SaveAsync();
                    _logger.LogInformation($"Create cuisine type in database.");
                    return Ok();
                }
                return StatusCode(404);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Something went wrong inside Post cuisineTypes action: {ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
