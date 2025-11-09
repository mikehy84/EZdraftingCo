

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
                .HasKey(g => g.Id); // Primary Key

            modelBuilder
                .Property(g => g.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)


            modelBuilder
                .Property(g => g.PhaseNumber)
                .IsRequired();

            modelBuilder
                .Property(a => a.ProjectId)
                .IsRequired();

            modelBuilder
                .HasIndex(a => new { a.PhaseNumber, a.ProjectId })
                .IsUnique();



            // Relationships Configuration
            modelBuilder
                .HasOne(a => a.Project)
                .WithMany(a => a.Phases)
                .HasForeignKey(a => a.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
