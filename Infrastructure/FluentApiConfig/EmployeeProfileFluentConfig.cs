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
    public class EmployeeProfileFluentConfig : IEntityTypeConfiguration<EmployeeProfile>
    {
        public void Configure(EntityTypeBuilder<EmployeeProfile> modelBuilder)
        {
            modelBuilder
                .HasKey(ep => ep.PersonId);

            modelBuilder
                .Property(ep => ep.PersonId)
                .IsRequired();

            modelBuilder
                .Property(ep => ep.SinEncrypted)
                .IsRequired()
                .HasMaxLength(512);

            modelBuilder
                .Property(ep => ep.SinHash)
                .HasMaxLength(64);

            modelBuilder
                .Property(ep => ep.SinLast3)
                .HasMaxLength(3)
                .IsRequired();

            // Unique index on SinHash
            modelBuilder
                .HasIndex(ep => ep.SinHash)
                .IsUnique()
                .HasFilter("[SinHash] IS NOT NULL"); // Only rows where AccountId has a value participate in the unique index.

            // Relationships
            modelBuilder
                .HasOne(ep => ep.Person)
                .WithOne(p => p.EmployeeProfile)
                .HasForeignKey<EmployeeProfile>(ep => ep.PersonId);
        }
    }
}
