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
        public void AddClimber(string name, string nationality, int mountain)
        {
            DbContext.ClimberTable.Add(new Climber { Climbers_Name = name, Nationality = nationality, Mountain_Id = mountain});
            DbContext.SaveChanges();
        }
        public Mountain GetMountainById(int id)
        {
            var mountain = DbContext.MountainTable.FirstOrDefault(a => a.Id == id);
            return mountain;
        }
    }
}
