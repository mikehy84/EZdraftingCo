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
                .Property(td => td.Title)
                .IsRequired()
                .HasMaxLength(80);

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

            // Unique Constraint Configuration
            modelBuilder
                .HasIndex(td => new { td.TaskNameId, td.Title, td.ProjectId, td.PhaseId })
                .IsUnique();

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
                .HasForeignKey(td => td.AreaId)
                .OnDelete(DeleteBehavior.SetNull)
                .IsRequired(false);

            modelBuilder
                .HasOne(td => td.Priority)
                .WithMany(pr => pr.TaskDetails)
                .HasForeignKey(td => td.PriorityId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Property(td => td.TaskStateId)
                .HasDefaultValue(1)
                .IsRequired();

            modelBuilder
                .HasOne(td => td.TaskState)
                .WithMany(ts => ts.TaskDetails)
                .HasForeignKey(td => td.TaskStateId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // Navigation properties
            modelBuilder
                .Navigation(td => td.TaskAssignments);


            // Seeding initial data
            modelBuilder
                .HasData(
                    new TaskDetail
                    {
                        Id = 1,
                        TaskNameId = 1,
                        Title = "Column to beam",
                        ProjectId = 1,
                        PhaseId = 1,
                        AreaId = null,
                        PriorityId = 1,
                        Description = "Initial task detail description",
                        EstimatedHours = 40,
                        DueDate = DateTime.UtcNow.AddDays(10),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    },
                    new TaskDetail
                    {
                        Id = 2,
                        TaskNameId = 2,
                        Title = "Column layout",
                        ProjectId = 1,
                        PhaseId = 2,
                        AreaId = null,
                        PriorityId = 2,
                        Description = "Second task detail description",
                        EstimatedHours = 20,
                        DueDate = DateTime.UtcNow.AddDays(15),
                        CreatedAt = DateTime.UtcNow,
                        UpdatedAt = DateTime.UtcNow
                    }
                );
        }
    }
}
