using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountaineering.Models.ViewModels
{
    public class ViewModel
    {
        public Climber ClimberVM { get; set; }
        public Mountain MountainVM { get; set; }
        public List<Climber> ClimbersVM { get; set; }
        public List<Mountain> MountainsVM { get; set; }
    }
}
