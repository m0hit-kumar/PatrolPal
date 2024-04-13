using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatrolPal.DTO;
using PatrolPal.Enum;
using PatrolPal.Interface;
using PatrolPal.Model;
using System.Runtime.Serialization;

namespace PatrolPal.Controllers
{
    [ApiController]
    [Route("map-stats")]
    public class MapStatsController : ControllerBase
    {

        private readonly EntityContext _dbContext;

        public MapStatsController(EntityContext dbContext)
        {
            _dbContext = dbContext;
        }
        [HttpGet]
        public async Task<ActionResult<List<MapStats>>> Get()
        {
            var mapStats = await _dbContext.MapStats.ToListAsync();
            return mapStats;
        }

        [HttpGet("{districtId}")]
        public async Task<ActionResult<DistrictsDetailsRes>> DistrctwiseData(DistrictEnum districtId)
        {
            var cameras = await _dbContext.CameraLocation.Where(c => c.District == districtId).ToListAsync();
            var stations = await _dbContext.PoliceStations.Where(x => x.District == districtId).ToListAsync();

            DistrictsDetailsRes response = new DistrictsDetailsRes() { Camera = cameras, Stations = stations };
            return response;
        }
        [NonAction]
        public static string? getEnumMemberValue(DistrictEnum enumValue)
        {
            var enumMemberAttribute = enumValue.GetType()
                .GetMember(enumValue.ToString())
                .FirstOrDefault()?
                .GetCustomAttributes(typeof(EnumMemberAttribute), false)
                .FirstOrDefault() as EnumMemberAttribute;

            return enumMemberAttribute?.Value; // This should give you "Bagalkot"

        }
    }
}