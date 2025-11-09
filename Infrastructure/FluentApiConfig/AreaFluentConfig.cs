using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentApiConfig
{
    public class AreaFluentConfig : IEntityTypeConfiguration<Area>
    {
        public void Configure(EntityTypeBuilder<Area> modelBuilder)
        {
            modelBuilder
                .HasKey(a => a.Id); // Primary Key

            modelBuilder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(a => a.Name)
                .IsRequired();

            modelBuilder
                .Property(a => a.Name)
                .HasMaxLength(100);

            modelBuilder
                .Property(a => a.ProjectId)
                .IsRequired();

            modelBuilder
                .HasIndex(a => new { a.Name, a.ProjectId })
                .IsUnique();

            // Relationships Configuration
            modelBuilder
                .HasOne(a => a.Project)
                .WithMany(p => p.Areas)
                .HasForeignKey(a => a.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
