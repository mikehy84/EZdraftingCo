using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class TaskDetailFluentConfig : IEntityTypeConfiguration<TaskDetail>
    {
        public void Configure(EntityTypeBuilder<TaskDetail> modelBuilder)
        {
            modelBuilder
                .HasKey(td => td.Id);

            modelBuilder
                .Property(td => td.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(td => td.Description)
                .IsRequired()
                .HasMaxLength(1000);

            modelBuilder
                .Property(td => td.EstimatedHours)
                .IsRequired();

            modelBuilder
                .Property(td => td.DueDate)
                .IsRequired();

            // Relationships
            modelBuilder
                .HasOne(td => td.TaskName)
                .WithMany(tn => tn.TaskDetails)
                .HasForeignKey(td => td.TaskNameId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(td => td.Project)
                .WithMany(p => p.TaskDetails)
                .HasForeignKey(td => td.ProjectId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(td => td.Phase)
                .WithMany(ph => ph.TaskDetails)
                .HasForeignKey(td => td.PhaseId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(td => td.Area)
                .WithMany(a => a.TaskDetails)
                .HasForeignKey(td => td.PriorityId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(td => td.Priority)
                .WithMany(pr => pr.TaskDetails)
                .HasForeignKey(td => td.PriorityId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // Navigation properties
            modelBuilder
                .Navigation(td => td.TaskLog);

            modelBuilder
                .Navigation(td => td.TaskAssignments);
        }
    }
}
