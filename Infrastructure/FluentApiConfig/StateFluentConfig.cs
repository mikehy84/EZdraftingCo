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
    public class StateFluentConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> modelBuilder)
        {
            modelBuilder
                .HasKey(s => s.Id);

            modelBuilder
                .Property(s => s.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder
                .Property(s => s.Code)
                .IsRequired()
                .HasMaxLength(10);

            modelBuilder
                .Property(s => s.CountryId)
                .IsRequired();


            // Constraints
            modelBuilder
                .HasIndex(s => s.Name)
                .IsUnique();

            modelBuilder
                .HasIndex(s => s.Code)
                .IsUnique();


            // Relationships
            modelBuilder
                .HasOne(s => s.Country)
                .WithMany(c => c.States)
                .HasForeignKey(s => s.CountryId)
                .OnDelete(DeleteBehavior.Restrict);


            // Navigations
            modelBuilder
                .Navigation(s => s.Addresses);
        }
    }
}
