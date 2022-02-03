using Microsoft.AspNetCore.Mvc;
using TestApi.Dto;

namespace TestApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EntityController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<EntityController> _logger;

        public EntityController(ILogger<EntityController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "SearchEntities")]
        public SearchFilterResponse Get([FromQuery] SearchFilterRequest filter)
        {
        }
    }
}