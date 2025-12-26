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
        }
    }
}
