using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class ClientProjectFluentConfig : IEntityTypeConfiguration<ClientProject>
    {
        public void Configure(EntityTypeBuilder<ClientProject> modelBuilder)
        {
            modelBuilder
                .HasKey(cp => cp.Id);

            modelBuilder
                .Property(cp => cp.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(cp => cp.ProjectNo)
                .IsRequired();

            // Unique Constraints
            modelBuilder
                .HasIndex(cp => new { cp.CompanyId, cp.ProjectNo })
                .IsUnique();

            modelBuilder
                .HasIndex(cp => cp.ProjectName)
                .IsUnique();

            modelBuilder
                .Property(cp => cp.ProjectRate)
                .HasPrecision(10, 2); // up to 99999999.99

            // Relationships Configuration
            modelBuilder
                .HasOne(cp => cp.ClientPm)
                .WithMany(p => p.ClientProjects)
                .HasForeignKey(cp => cp.ClientPmId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(cp => cp.Company)
                .WithMany(c => c.ClientProjects)
                .HasForeignKey(cp => cp.CompanyId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Navigation(cp => cp.Projects);


            // Seeding initial data
            modelBuilder
                .HasData(
                    new ClientProject
                    {
                        Id = 1,
                        CompanyId = 2,
                        ProjectNo = "CL-PRJ-001",
                        ProjectName = "Downtown Office",
                        Location = "New York, NY",
                        EstimatedHour = 1240,
                        ProjectRate = 150.00m,
                        AwardedAt = new DateTime(2025, 1, 15),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new ClientProject
                    {
                        Id = 2,
                        CompanyId = 2,
                        ProjectNo = "CL-PRJ-002",
                        ProjectName = "Lakeside Residential Complex",
                        Location = "Chicago, IL",
                        EstimatedHour = 3000,
                        ProjectRate = 120.00m,
                        AwardedAt = new DateTime(2023, 3, 10),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                );
        }
    }
}
