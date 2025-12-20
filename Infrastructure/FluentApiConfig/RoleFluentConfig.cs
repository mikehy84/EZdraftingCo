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
    public class RoleFluentConfig : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> modelBuilder) 
        {
            modelBuilder
                .HasKey(r => r.Id); // Primary Key

            modelBuilder
                .Property(r => r.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(r => r.Name)
                .IsRequired();
        }
    }
}
