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

            modelBuilder
                .Property(ta => ta.TaskDetailId)
                .IsRequired();

            modelBuilder
                .Property(ta => ta.AssignorId)
                .IsRequired();

            modelBuilder
                .Property(ta => ta.AssigneeId)
                .IsRequired();



            // Unique constraint to prevent duplicate assignments of the same task to the same assignee
            modelBuilder
                .HasIndex(ta => new { ta.TaskDetailId, ta.AssigneeId })
                .IsUnique();

            // Relationships
            modelBuilder
                .HasOne(ta => ta.TaskDetail)
                .WithMany(td => td.TaskAssignments)
                .HasForeignKey(ta => ta.TaskDetailId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(ta => ta.Assignor)
                .WithMany(person => person.AssignedTasks)
                .HasForeignKey(ta => ta.AssignorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(ta => ta.Assignee)
                .WithMany(person => person.ReceivedTasks)
                .HasForeignKey(ta => ta.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict);


            // Navigation properties
            modelBuilder
                .Navigation(ta => ta.TaskProgresses);
        }
    }
}
