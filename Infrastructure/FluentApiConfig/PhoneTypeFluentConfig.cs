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
    public class PhoneTypeFluentConfig : IEntityTypeConfiguration<PhoneType>
    {
        public void Configure(EntityTypeBuilder<PhoneType> modelBuilder)
        {
            modelBuilder
                .HasKey(pt => pt.Id);

            modelBuilder
                .Property(pt => pt.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(pt => pt.Type)
                .HasMaxLength(10)
                .IsRequired();

            // Unique
            modelBuilder
                .HasIndex(pt => pt.Type)
                .IsUnique();

            // Relationship
            modelBuilder
                .Navigation(pt => pt.PhoneNumbers);


            // Seeding initial data
            modelBuilder.HasData(
                new PhoneType { Id = 1, Type = "Mobile" },
                new PhoneType { Id = 2, Type = "Work" },
                new PhoneType { Id = 3, Type = "Home" },
                new PhoneType { Id = 4, Type = "Office" },
                new PhoneType { Id = 5, Type = "Fax" },
                new PhoneType { Id = 6, Type = "Emergency" },
                new PhoneType { Id = 7, Type = "Site" },
                new PhoneType { Id = 8, Type = "After Hours" }
            );
        }
    }
}
