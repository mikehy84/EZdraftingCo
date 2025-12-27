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
                .Navigation(ts => ts.TaskLogs);
        }
    }
}
