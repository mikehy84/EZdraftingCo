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
        }
    }
}
