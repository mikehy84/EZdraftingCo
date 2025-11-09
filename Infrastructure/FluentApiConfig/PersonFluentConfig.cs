using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class PersonFluentConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> modelBuilder)
        {
            modelBuilder
                .HasKey(x => x.Id); // Primary Key

            modelBuilder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .HasIndex(x => x.SIN)
                .IsUnique(); // unique constraint on SIN

            modelBuilder
                .Property(x => x.FirstName)
                .IsRequired()
                .HasMaxLength(50); // FirstName is required with max length 50

            modelBuilder
                .Property(x => x.LastName)
                .IsRequired()
                .HasMaxLength(50); // LastName is required with max length 50

            modelBuilder
                .Property(x => x.JobId)
                .IsRequired();

            modelBuilder
                .Property(x => x.CompanyId)
                .IsRequired();

            // Relationships Configuration
            modelBuilder
                .HasOne(x => x.Job)
                .WithMany(x => x.Persons)
                .HasForeignKey(x => x.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(x => x.Job);

            modelBuilder
                .HasOne(x => x.Company)
                .WithMany(x => x.Persons)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(x => x.Company);
        }
    }
}
