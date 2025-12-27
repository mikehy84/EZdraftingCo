using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentApiConfig
{
    public class CountryFluentConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> modelBuilder)
        {
            modelBuilder
                .HasKey(c => c.Id);

            modelBuilder
                .Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .HasIndex(c => c.Name)
                .IsUnique();

            modelBuilder
                .HasIndex(c => c.IsoCode)
                .IsUnique();

            modelBuilder
                .Property(c => c.PhoneCode)
                .HasMaxLength(25)
                .IsRequired();

            var upperConverter = new ValueConverter<string, string>(
            v => v == null ? null! : v.Trim().ToUpperInvariant(),
            v => v);

            modelBuilder
                .Property(c => c.IsoCode)
                .HasMaxLength(8)
                .IsRequired()
                .HasConversion(upperConverter);
        }
    }
}
