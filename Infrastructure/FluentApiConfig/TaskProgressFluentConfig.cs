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
    public class TaskProgressFluentConfig : IEntityTypeConfiguration<TaskProgress>
    {
        public void Configure(EntityTypeBuilder<TaskProgress> modelBuilder)
        {
            modelBuilder
                .HasKey(tp => tp.Id);

            modelBuilder
                .Property(tp => tp.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(tp => tp.Date)
                .IsRequired();

            modelBuilder
                .Property(tp => tp.SpentHours)
                .IsRequired();

            // Relationships
            modelBuilder
                .HasOne(tp => tp.TaskAssignment)
                .WithMany(ta => ta.TaskProgresses)
                .HasForeignKey(tp => tp.TaskAssignmentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // Navigation properties
            modelBuilder
                .Navigation(tp => tp.TaskComments);


            // Seeding initial data
            modelBuilder
                .HasData(
                    new TaskProgress
                    {
                        Id = 1,
                        TaskAssignmentId = 1,
                        Date = new DateTime(2024, 1, 15),
                        SpentHours = 5.0,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new TaskProgress
                    {
                        Id = 2,
                        TaskAssignmentId = 2,
                        Date = new DateTime(2024, 1, 16),
                        SpentHours = 3.5,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new TaskProgress
                    {
                        Id = 3,
                        TaskAssignmentId = 1,
                        Date = new DateTime(2024, 1, 17),
                        SpentHours = 4.0,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new TaskProgress
                    {
                        Id = 4,
                        TaskAssignmentId = 2,
                        Date = new DateTime(2024, 1, 18),
                        SpentHours = 6.0,
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                );
        }
    }
}
