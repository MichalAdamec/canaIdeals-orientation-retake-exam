using Microsoft.EntityFrameworkCore;
using Mountaineering.Database;
using Mountaineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountaineering.Services
{
    public class MountainServices
    {
        public ApplicationDbContext DbContext { get; set; }
        public MountainServices(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public List<Climber> GetClimbers()
        {
            var savedClimbers = DbContext.ClimberTable.Include(a => a.Mountain).ToList();
            return savedClimbers;
        }
        public List<Mountain> GetMountains()
        {
            var savedMountains = DbContext.MountainTable.Include(a => a.Climbers).ToList();
            return savedMountains;
        }
        public List<Climber> GetClimbersByNationAndAlt(string nationality, int altitude)
        {
            var climbers = GetClimbers().Where(a => a.Nationality == nationality & a.Altitude >= altitude).OrderBy(a => a.Altitude).ToList();
            return climbers;
        }
    }
}
