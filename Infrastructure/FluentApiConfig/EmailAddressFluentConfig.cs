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
                .Property(ea => ea.PersonId)
                .IsRequired();

            modelBuilder
                .Property(ea => ea.Email)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder
                .HasIndex(ea => ea.Email)
                .IsUnique(); // Unique index on Email

            modelBuilder
                .HasIndex(ea => new { ea.PersonId, ea.Email})
                .IsUnique(); // Unique index on PersonId and Email combination

            modelBuilder
                .HasIndex(ea => ea.PersonId)
                .IsUnique()
                .HasFilter("[IsPrimary] = 1"); // Unique index on PersonId where IsPrimary is true


            // Relationships
            modelBuilder
                .HasOne(ea => ea.Person)
                .WithMany(p => p.EmailAddresses)
                .HasForeignKey(ea => ea.PersonId);
        }
    }
}
