using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class TaskNameFluentConfig : IEntityTypeConfiguration<TaskName>
    {
        public void Configure(EntityTypeBuilder<TaskName> modelBuilder)
        {
            modelBuilder
                .HasKey(tn => tn.Id); // Primary Key

            modelBuilder
                .Property(tn => tn.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(tn => tn.Name)
                .HasMaxLength(50)
                .IsRequired();


            // Unique Index on Name
            modelBuilder
                .HasIndex(tn => tn.Name)
                .IsUnique(); // Unique constraint on Name

            // Navigation properties
            modelBuilder
                .Navigation(tn => tn.TaskDetails);

            // Seeding initial data
            modelBuilder.HasData(
                new TaskName { Id = 1, Name = "Back Drafting_E Plans" },
                new TaskName { Id = 2, Name = "Back Drafting_Shop Dwgs" },
                new TaskName { Id = 3, Name = "Checking" },
                new TaskName { Id = 4, Name = "Connecting" },
                new TaskName { Id = 5, Name = "Editing" },
                new TaskName { Id = 6, Name = "Erection Drawings" },
                new TaskName { Id = 7, Name = "Modeling" },
                new TaskName { Id = 8, Name = "Project Management" }
            );
        }
    }
}
