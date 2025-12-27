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
        }
    }
}
