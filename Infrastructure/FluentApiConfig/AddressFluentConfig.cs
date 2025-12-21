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
    public class AddressFluentConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> modelBuilder)
        {
            modelBuilder
                .HasKey(a => a.Id);

            modelBuilder
                .Property(a => a.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); 

            modelBuilder
                .Property(a => a.StreetNumber)
                .IsRequired();

            modelBuilder
                .Property(a => a. StreetName)
                .IsRequired();

            modelBuilder
                .Property(a => a.City)
                .IsRequired();

            modelBuilder
                .Property(a => a.PostalCode)
                .IsRequired();

            modelBuilder
                .Property(a => a.StateId)
                .IsRequired();

            modelBuilder
                .Property(a => a.PersonId)
                .IsRequired();


            // Relationships

            modelBuilder
                .HasOne(a => a.State)
                .WithMany(s => s.Addresses)
                .HasForeignKey(a => a.StateId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(a => a.Person)
                .WithMany(p => p.Addresses)
                .HasForeignKey(a => a.PersonId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
