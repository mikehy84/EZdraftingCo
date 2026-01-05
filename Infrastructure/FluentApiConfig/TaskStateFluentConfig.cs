using Microsoft.EntityFrameworkCore;

using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentApiConfig
{
    public class TaskStateFluentConfig : IEntityTypeConfiguration<TaskState>
    {
        public void Configure(EntityTypeBuilder<TaskState> modelBuilder)
        {
            modelBuilder
                .HasKey(ts => ts.Id);

            modelBuilder
                .Property(ts => ts.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(ts => ts.Name)
                .IsRequired()
                .HasMaxLength(20);


            // Unique Constraints
            modelBuilder
                .HasIndex(ts => ts.Name)
                .IsUnique();

            // Navigation Properties
            modelBuilder
                .Navigation(ts => ts.TaskDetails);

            // Seeding initial data
            modelBuilder.HasData(
                new TaskState { Id = 1, Name = "New", Definition = "Task created but not started yet" },
                new TaskState { Id = 2, Name = "In Progress", Definition = "Actively being worked on" },
                new TaskState { Id = 3, Name = "Paused", Definition = "Temporarily stopped by choice (not blocked)" },
                new TaskState { Id = 4, Name = "Cancelled", Definition = "No longer required" },
                new TaskState { Id = 5, Name = "On Hold", Definition = "Blocked, waiting for input (RFI, approval, info)" },
                new TaskState { Id = 6, Name = "Completed", Definition = "Work finished and ready for review" },
                new TaskState { Id = 7, Name = "Closed", Definition = "Approved / accepted, no further action" }
            );
        }
    }
}
