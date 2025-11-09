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
        public DbSet<Area> Areas { get; set; }
        public DbSet<ClientProject> ClientProjects { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyCategory> CompanyCategores { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Phase> Phases { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskLog> TaskLogs { get; set; }
        public DbSet<TaskName> TaskNames { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AreaFluentConfig());
            modelBuilder.ApplyConfiguration(new ClientProjectFluentConfig());
            modelBuilder.ApplyConfiguration(new CompanyFluentConfig());
            modelBuilder.ApplyConfiguration(new CompanyCategoryFluentConfig());
            modelBuilder.ApplyConfiguration(new JobFluentConfig());
            modelBuilder.ApplyConfiguration(new PersonFluentConfig());
            modelBuilder.ApplyConfiguration(new PhaseFluentConfig());
            modelBuilder.ApplyConfiguration(new PriorityFluentConfig());
            modelBuilder.ApplyConfiguration(new ProjectFluentConfig());
            modelBuilder.ApplyConfiguration(new TaskLogFluentConfig());
            modelBuilder.ApplyConfiguration(new TaskNameFluentConfig());
            modelBuilder.ApplyConfiguration(new TaskStateFluentConfig());
        }
    }
}
