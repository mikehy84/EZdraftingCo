using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentApiConfig
{
    public class TaskAssignmentFluentConfig : IEntityTypeConfiguration<TaskAssignment>
    {
        public void Configure(EntityTypeBuilder<TaskAssignment> modelBuilder)
        {
            modelBuilder
                .HasKey(ta => ta.Id);

            modelBuilder
                .Property(ta => ta.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();


            // Unique constraint to prevent duplicate assignments of the same task to the same assignee
            modelBuilder
                .HasIndex(ta => new { ta.TaskDetailId, ta.TaskAssigneeId })
                .IsUnique();

            // Relationships
            modelBuilder
                .HasOne(ta => ta.TaskDetail)
                .WithMany(td => td.TaskAssignments)
                .HasForeignKey(ta => ta.TaskDetailId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();  

            modelBuilder
                .HasOne(ta => ta.TaskAssignor)
                .WithMany(person => person.AssignedTasks)
                .HasForeignKey(ta => ta.TaskAssignorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(ta => ta.TaskAssignee)
                .WithMany(person => person.ReceivedTasks)
                .HasForeignKey(ta => ta.TaskAssigneeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Navigation properties
            modelBuilder
                .Navigation(ta => ta.TaskProgresses);
        }
    }
}
