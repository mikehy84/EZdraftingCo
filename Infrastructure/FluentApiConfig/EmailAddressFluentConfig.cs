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
    public class EmailAddressFluentConfig : IEntityTypeConfiguration<EmailAddress>
    {
        public void Configure(EntityTypeBuilder<EmailAddress> modelBuilder)
        {
            modelBuilder
                .HasKey(ea => ea.Id);

            modelBuilder
                .Property(ea => ea.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(ea => ea.Email)
                .IsRequired()
                .HasMaxLength(100);

            // Unique Indexes
            modelBuilder
                .HasIndex(ea => ea.Email)
                .IsUnique(); // Unique index on Email

            modelBuilder
                .HasIndex(ea => ea.PersonId)
                .IsUnique()
                .HasFilter("[IsPrimary] = 1"); // Only rows where IsPrimary = true participate in the unique index.

            modelBuilder
                .HasIndex(ea => new { ea.PersonId, ea.Email })
                .IsUnique(); // Unique index on PersonId and Email combination

            // Relationships
            modelBuilder
                .HasOne(ea => ea.Person)
                .WithMany(p => p.EmailAddresses)
                .HasForeignKey(ea => ea.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Seeding initial data
            modelBuilder.HasData(
                new EmailAddress
                {
                    Id = 1,
                    PersonId = 1,
                    Email = "lgrannon@qualitydraftingco.com",
                    IsPrimary = true
                },
                new EmailAddress
                {
                    Id = 2,
                    PersonId = 2,
                    Email = "mharvey@qualitydraftingco.com",
                    IsPrimary = true
                }
            );
        }
    }
}
