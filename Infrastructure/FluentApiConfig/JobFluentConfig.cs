using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class JobFluentConfig : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> modelBuilder)
        {
            modelBuilder
                .HasKey(j => j.Id); // Primary Key

            modelBuilder
                .Property(j => j.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired();

            // Unique constraint on Title
            modelBuilder
                .HasIndex(j => j.Title)
                .IsUnique();

            // Relationships
            modelBuilder
                .Navigation(j => j.EmployeeProfiles);


            // Seeding initial data
            modelBuilder.HasData(
                new Job { Id = 1, Title = "President", Description = "General manager" },
                new Job { Id = 2, Title = "Junior Detailer", Description = "Entry-level detailer with 1–2 years of experience under supervision." },
                new Job { Id = 3, Title = "Intermediate Detailer", Description = "Detailer with solid Tekla experience handling standard projects independently." },
                new Job { Id = 4, Title = "Senior Detailer", Description = "Experienced detailer responsible for complex steel structures and quality control." },
                new Job { Id = 5, Title = "Lead Detailer", Description = "Leads detailing teams, coordinates workflow, and ensures drawing standards." },
                new Job { Id = 6, Title = "Project Manager", Description = "Manages detailing projects, client communication, and delivery milestones." },
                new Job { Id = 7, Title = "Checker", Description = "Reviews shop drawings for accuracy, standards, and constructability." },
                new Job { Id = 8, Title = "Junior Drafter", Description = "Entry-level drafter assisting with drawings, markups, and basic Tekla outputs." },
                new Job { Id = 9, Title = "Intermediate Drafter", Description = "Produces shop drawings independently under guidance, with solid Tekla drafting skills." },
                new Job { Id = 10, Title = "Senior Drafter", Description = "Handles complex drawings, coordinates revisions, and supports detailing quality." },
                new Job { Id = 11, Title = "Client Project Manager", Description = "Client-side project manager overseeing scope, schedule, and approvals." },
                new Job { Id = 12, Title = "Client Representative", Description = "Primary client contact responsible for coordination and communication." },
                new Job { Id = 13, Title = "Client Engineer", Description = "Client-side engineer reviewing drawings, RFIs, and technical submissions." },
                new Job { Id = 14, Title = "Client Site Manager", Description = "Represents the client on site and coordinates construction activities." },
                new Job { Id = 15, Title = "Client QA/QC", Description = "Reviews quality, compliance, and drawing accuracy on behalf of the client." },
                new Job { Id = 16, Title = "Client Coordinator", Description = "Supports client project team with documentation, schedules, and submissions." }
            );
        }
    }
}
