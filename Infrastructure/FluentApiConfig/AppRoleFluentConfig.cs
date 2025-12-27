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
    public class AppRoleFluentConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> modelBuilder) 
        {
            modelBuilder
                .HasKey(r => r.Id); // Primary Key

            modelBuilder
                .Property(r => r.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(r => r.Name)
                .HasMaxLength(20)
                .IsRequired();


            // Constraints
            modelBuilder
                .HasIndex(r => r.Name)
                .IsUnique(); // Unique constraint on Name


            // Relationships
            modelBuilder
                .Navigation(r => r.AssignedRoles);
        }
    }
}
