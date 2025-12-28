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
    public class TaskLogFluentConfig : IEntityTypeConfiguration<TaskLog>
    {
        public void Configure(EntityTypeBuilder<TaskLog> modelBuilder)
        {
            modelBuilder
                .HasKey(tl => tl.Id);

            modelBuilder
                .Property(tl => tl.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .HasIndex(tl => tl.TaskDetailId)
                .IsUnique();


            // Relationships
            modelBuilder
                .HasOne(tl => tl.TaskDetail)
                .WithOne(td => td.TaskLog)
                .HasForeignKey<TaskLog>(tl => tl.TaskDetailId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            modelBuilder
                .HasOne(tl => tl.TaskState)
                .WithMany(ts => ts.TaskLogs)
                .HasForeignKey(tl => tl.TaskStateId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Seeding Initial Data
            modelBuilder.HasData(
                new TaskLog
                {
                    Id = 1,
                    TaskDetailId = 1,
                    TaskStateId = 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                },
                new TaskLog
                {
                    Id = 2,
                    TaskDetailId = 2,
                    TaskStateId = 1,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow
                }
            );
        }
    }
}
