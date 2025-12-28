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
                .Property(x => x.RatePerHour)
                .IsRequired()
                .HasPrecision(10, 2); // up to 99999999.99

            modelBuilder
                .Property(ep => ep.SinEncrypted)
                .HasMaxLength(512)
                .IsRequired();

            modelBuilder
                .Property(ep => ep.SinHash)
                .HasMaxLength(64)
                .IsRequired();

            modelBuilder
                .Property(ep => ep.SinLast3)
                .HasMaxLength(3)
                .IsRequired();

            // Unique index on SinHash
            modelBuilder
                .HasIndex(ep => ep.SinHash)
                .IsUnique();


            // Relationships
            modelBuilder
                .HasOne(ep => ep.Person)
                .WithOne(p => p.EmployeeProfile)
                .HasForeignKey<EmployeeProfile>(ep => ep.PersonId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
               .HasOne(ep => ep.Job)
               .WithMany(j => j.EmployeeProfiles)
               .HasForeignKey(ep => ep.JobId)
               .OnDelete(DeleteBehavior.Restrict)
               .IsRequired();
        }
    }
}
