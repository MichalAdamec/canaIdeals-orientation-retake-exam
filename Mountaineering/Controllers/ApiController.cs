using Microsoft.AspNetCore.Mvc;
using Mountaineering.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountaineering.Controllers
{
    [Route("api")]
    public class ApiController : Controller
    {
        public MountainServices MountainServices { get; set; }
        public ApiController(MountainServices services)
        {
            MountainServices = services;
        }

        [HttpGet("climbers?nationality={nationality}&above={above}")]
        public IActionResult Index([FromQuery] string nationality, int above)
        {
            var sortedClimbers = MountainServices.GetClimbersByNationAndAlt(nationality, above);
            return Ok(sortedClimbers);
        }
    }
}
