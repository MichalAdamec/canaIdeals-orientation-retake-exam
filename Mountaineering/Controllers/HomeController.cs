using Microsoft.AspNetCore.Mvc;
using Mountaineering.Database;
using Mountaineering.Models.ViewModels;
using Mountaineering.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountaineering.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        public MountainServices MountainServices { get; set; }
        public HomeController(MountainServices services)
        {
            MountainServices = services;
        }

        [HttpGet("")]
        public IActionResult MainPage()
        {
            ViewModel viewModel = new ViewModel() { ClimbersVM = MountainServices.GetClimbers(), MountainsVM = MountainServices.GetMountains() };

            return View(viewModel);
        }

        [HttpPost("climbers")]
        public IActionResult Climbers([FromForm] string name, string nationality, int mountain_Id)
        {
            MountainServices.AddClimber(name, nationality, mountain_Id);
            return RedirectToAction("MainPage");
        }

    }
}
