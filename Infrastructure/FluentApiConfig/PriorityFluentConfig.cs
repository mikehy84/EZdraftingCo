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
    public class PriorityFluentConfig : IEntityTypeConfiguration<Priority>
    {
        public void Configure(EntityTypeBuilder<Priority> modelBuilder)
        {
            modelBuilder
                .HasKey(p => p.Id); // Primary Key

            modelBuilder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(p => p.Name)
                .HasMaxLength(12)
                .IsRequired();

            // Constraints
            modelBuilder
                .HasIndex(p => p.Name)
                .IsUnique(); // Unique constraint on Name

            // Relationships
            modelBuilder
                .Navigation(p => p.TaskLogs);
        }
    }
}
