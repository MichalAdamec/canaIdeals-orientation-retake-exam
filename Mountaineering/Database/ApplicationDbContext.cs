using Microsoft.EntityFrameworkCore;
using Mountaineering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mountaineering.Database
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Climber> ClimberTable { get; set; }
        public DbSet<Mountain> MountainTable { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)  
        {
            modelBuilder.Entity<Mountain>()
                .HasMany<Climber>(a => a.Climbers)
                .WithOne(b => b.Mountain)  
                .HasForeignKey(a => a.Mountain_Id)
                .IsRequired(true);
        }
    }
}
