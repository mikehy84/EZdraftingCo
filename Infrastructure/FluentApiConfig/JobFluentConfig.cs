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
                .HasKey(x => x.Id); // Primary Key

            modelBuilder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .HasIndex(x => x.Title)
                .IsUnique();

            modelBuilder
                .Property(x => x.Title)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Property(x => x.RatePerHour)
                .IsRequired()
                .HasPrecision(10, 2); // up to 99999999.99
        }
    }
}
