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

            modelBuilder
                .Property(x => x.RatePerHour)
                .IsRequired()
                .HasPrecision(10, 2); // up to 99999999.99

            // Unique constraint on Title
            modelBuilder
                .HasIndex(j => j.Title)
                .IsUnique();

            // Relationships
            modelBuilder
                .Navigation(j => j.Persons);
        }
    }
}
