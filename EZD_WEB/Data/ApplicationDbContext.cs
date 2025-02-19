using EZD_WEB.Models;
using Microsoft.EntityFrameworkCore;

namespace EZD_WEB.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }
    }
}
