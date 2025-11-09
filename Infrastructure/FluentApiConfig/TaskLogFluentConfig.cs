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
                .HasKey(a => a.Id);

            modelBuilder
                .Property(a => a.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(u => u.ProjectId)
                .IsRequired();

            modelBuilder
                .Property(u => u.AssignorId)
                .IsRequired();

            modelBuilder
                .Property(u => u.TaskId)
                .IsRequired();

            modelBuilder
                .Property(u => u.Description)
                .IsRequired();

            modelBuilder
                .Property(u => u.PriorityId)
                .IsRequired();

            modelBuilder
                .Property(u => u.EstimatedHours)
                .IsRequired();

            // Relationships
            modelBuilder
                .HasOne(u => u.Project)
                .WithMany(u => u.TaskLogs)
                .HasForeignKey(u => u.ProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(u => u.Project);


            modelBuilder
                .HasOne(e => e.Assignor)
                .WithMany(e => e.AssignedTasks)
                .HasForeignKey(e => e.AssignorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.Assignor);


            modelBuilder
                .HasOne(e => e.Assignee)
                .WithMany(e => e.ReceivedTasks)
                .HasForeignKey(e => e.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.Assignee);


            modelBuilder
                .HasOne(e => e.Phase)
                .WithMany(e => e.TaskLogs)
                .HasForeignKey(e => e.PhaseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.Phase);


            modelBuilder
                .HasOne(e => e.Area)
                .WithMany(e => e.TaskLogs)
                .HasForeignKey(e => e.AreaId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.Area);


            modelBuilder
                .HasOne(e => e.Task)
                .WithMany(e => e.TaskLogs)
                .HasForeignKey(e => e.TaskId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.Task);


            modelBuilder
                .HasOne(e => e.Priority)
                .WithMany(e => e.TaskLogs)
                .HasForeignKey(e => e.PriorityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.Priority);


            modelBuilder
                .HasOne(e => e.TaskState)
                .WithMany(e => e.TaskLogs)
                .HasForeignKey(e => e.StatusId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(e => e.TaskState);
        }
    }
}
