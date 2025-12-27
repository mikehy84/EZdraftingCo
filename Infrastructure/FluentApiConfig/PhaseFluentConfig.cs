

using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentApiConfig
{
    public class PhaseFluentConfig : IEntityTypeConfiguration<Phase>
    {
        public void Configure(EntityTypeBuilder<Phase> modelBuilder)
        {
            modelBuilder
                .HasKey(ph => ph.Id); // Primary Key

            modelBuilder
                .Property(ph => ph.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(ph => ph.PhaseNumber)
                .IsRequired();

            modelBuilder
                .HasIndex(ph => new { ph.PhaseNumber, ph.ProjectId })
                .IsUnique();


            // Relationships Configuration
            modelBuilder
                .HasOne(ph => ph.Project)
                .WithMany(proj => proj.Phases)
                .HasForeignKey(ph => ph.ProjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // Navigation Properties
            modelBuilder
                .Navigation(ph => ph.TaskDetails);
        }
    }
}
