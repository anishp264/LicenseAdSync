using LicenseAdSync.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace LicenseAdSync.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AircraftServiceController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            AircraftService aircraftService = new AircraftService();
            return aircraftService.GetAircraft();
        }
    }
}
