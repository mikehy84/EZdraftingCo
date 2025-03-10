using EZD_WEB.Models;
using Microsoft.EntityFrameworkCore;

namespace EZD_WEB.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasData(
                new Project { 
                    Id = 1,
                    ProjectName="Parand Project",
                    BuildingName="AUX",
                    Description="It was a great job",
                    Weight= 2500
                }
            );
        }
    }
}
