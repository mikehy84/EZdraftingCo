using Domain.Entities;
using Infrastructure.FluentApiConfig;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    //public class ApplicationDbContext : IdentityDbContext<AppUser>
    public class ApplicationDbContext: DbContext
    {

        public ApplicationDbContext() { }


        //directly pass connection string
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)

            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=EZDrafting;Trusted_Connection=True;TrustServerCertificate=True;");
            }
        }



        //public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        //public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ClientProject> ClientProjects { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyCategory> CompanyCategores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClientProjectFluentConfig());
            modelBuilder.ApplyConfiguration(new CompanyCategoryFluentConfig());
            modelBuilder.ApplyConfiguration(new CompanyFluentConfig());
            modelBuilder.ApplyConfiguration(new JobFluentConfig());
            modelBuilder.ApplyConfiguration(new PersonFluentConfig());
            modelBuilder.ApplyConfiguration(new ProjectFluentConfig());
        }
    }
}
