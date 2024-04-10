using Microsoft.AspNetCore.Mvc;
using PatrolPal.Interface;

namespace PatrolPal.Controllers
{
    [ApiController]
    [Route("map-stats")]
    public class MapStatsController : ControllerBase
    {

        private readonly IMapStatsRepo _mapStatsRepo;

        public MapStatsController(IMapStatsRepo mapStatsRepo)
        {
            _mapStatsRepo = mapStatsRepo;
        }
        [HttpGet("Forecast")]
        public ActionResult<string> Get()
        {
            return "hello";
        }
    }
}