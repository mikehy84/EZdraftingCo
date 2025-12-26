using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class AreaFluentConfig : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> modelBuilder)
        {
            modelBuilder
                .HasKey(a => a.Id); // Primary Key

            modelBuilder
                .Property(a => a.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .Property(a => a.ProjectId)
                .IsRequired();

            modelBuilder
                .HasIndex(a => new { a.Name, a.ProjectId })
                .IsUnique();

            // Relationships Configuration
            modelBuilder
                .HasOne(a => a.Project)
                .WithMany(p => p.Areas)
                .HasForeignKey(a => a.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);


            modelBuilder
                .Navigation(a => a.TaskDetails);
        }
    }
}
