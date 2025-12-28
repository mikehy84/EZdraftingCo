using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class ProjectFluentConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> modelBuilder)
        {
            modelBuilder
                .HasKey(p => p.Id); // Primary Key

            modelBuilder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            

            modelBuilder
                .Property(p => p.InternalProjectNo)
                .IsRequired();


            // Constraints
            modelBuilder
                .HasIndex(p => p.InternalProjectNo)
                .IsUnique();


            // Relationships Configuration
            modelBuilder
                .HasOne(p => p.ProjectManager)
                .WithMany(person => person.Projects)
                .HasForeignKey(p => p.ProjectManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(p => p.ClientProject)
                .WithMany(person => person.Projects)
                .HasForeignKey(p => p.ClientProjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Navigation Properties Configuration
            modelBuilder
                .Navigation(p => p.TaskDetails);

            modelBuilder
                .Navigation(p => p.Phases);

            modelBuilder
                .Navigation(p => p.Areas);


            // Seeding initial data
            modelBuilder
                .HasData(
                    new Project
                    {
                        Id = 1,
                        InternalProjectNo = "Internal-PRJ-001",
                        ProjectManagerId = 2,
                        ActualHours = 0,
                        StartDate = new DateTime(2024, 1, 1),
                        EndDate = new DateTime(2024, 12, 31),
                        IsClosed = false,
                        ClientProjectId = 1,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Project
                    {
                        Id = 2,
                        InternalProjectNo = "Internal-PRJ-002",
                        ProjectManagerId = 2,
                        ActualHours = 0,
                        StartDate = new DateTime(2024, 2, 1),
                        EndDate = new DateTime(2024, 11, 30),
                        IsClosed = false,
                        ClientProjectId = 2,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                );
        }
    }
}
