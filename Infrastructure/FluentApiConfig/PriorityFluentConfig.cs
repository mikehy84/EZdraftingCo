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

            // Relationship properties
            modelBuilder
                .Navigation(p => p.TaskDetails);


            // Seeding initial data
            modelBuilder.HasData(
                new Priority { Id = 1, Name = "Urgent", Definition = "High risk of incorrect fabrication; Stop current taks; Fix immediately" },
                new Priority { Id = 2, Name = "High", Definition = "Important detailing task or issue; should be addressed soon" },
                new Priority { Id = 3, Name = "Medium", Definition = "Normal detailing task or issue" },
                new Priority { Id = 4, Name = "Low", Definition = "Minor detailing task or issue" },
                new Priority { Id = 5, Name = "Trivial", Definition = "Cosmetic or documentation-only issue with no production impact" }
            );
        }
    }
}
