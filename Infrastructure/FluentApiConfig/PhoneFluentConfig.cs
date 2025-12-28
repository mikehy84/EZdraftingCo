using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentApiConfig
{
    public class PhoneFluentConfig : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> modelBuilder)
        {
            modelBuilder
                .HasKey(p => p.Id);

            modelBuilder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(p => p.PhoneNumber)
                .HasMaxLength(12)
                .IsRequired();

            // Unique Constraint
            modelBuilder
                .HasIndex(p => p.PersonId)
                .IsUnique()
                .HasFilter("[IsPrimary] = 1"); // Only rows where IsPrimary = true participate in the unique index.

            // Relationships
            modelBuilder
                .HasOne(p => p.PhoneType)
                .WithMany(pt => pt.PhoneNumbers)
                .HasForeignKey(p => p.TypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(p => p.Person)
                .WithMany(pr => pr.PhoneNumbers)
                .HasForeignKey(p => p.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(p => p.Country)
                .WithMany(c => c.Phones)
                .HasForeignKey(p => p.CountryId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Seeding Initial Data
            modelBuilder
                .HasData(
                    new Phone
                    {
                        Id = 1,
                        TypeId = 1,
                        PersonId = 1,
                        CountryId = 1,
                        PhoneNumber = "1234567890",
                        IsPrimary = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new Phone
                    {
                        Id = 2,
                        TypeId = 2,
                        PersonId = 2,
                        CountryId = 1,
                        PhoneNumber = "0987654321",
                        IsPrimary = true,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                );
        }
    }
}
