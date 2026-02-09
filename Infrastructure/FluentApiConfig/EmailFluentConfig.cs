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
    public class EmailFluentConfig : IEntityTypeConfiguration<Email>
    {
        public void Configure(EntityTypeBuilder<Email> modelBuilder)
        {
            modelBuilder
                .HasKey(ea => ea.Id);

            modelBuilder
                .Property(ea => ea.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(ea => ea.EmailAddress)
                .IsRequired()
                .HasMaxLength(100);

            // Unique Indexes
            modelBuilder
                .HasIndex(ea => ea.EmailAddress)
                .IsUnique(); // Unique index on Email

            modelBuilder
                .HasIndex(ea => ea.PersonId)
                .IsUnique()
                .HasFilter("[IsPrimary] = 1"); // Only rows where IsPrimary = true participate in the unique index.

            modelBuilder
                .HasIndex(ea => new { ea.PersonId, ea.EmailAddress })
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
                new Email
                {
                    Id = 1,
                    PersonId = 1,
                    EmailAddress = "lgrannon@qualitydraftingco.com",
                    IsPrimary = true
                },
                new Email
                {
                    Id = 2,
                    PersonId = 2,
                    EmailAddress = "mharvey@qualitydraftingco.com",
                    IsPrimary = true
                }
            );
        }
    }
}
