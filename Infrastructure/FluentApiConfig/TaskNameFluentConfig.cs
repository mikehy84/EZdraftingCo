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
                .HasKey(a => a.Id); // Primary Key

            modelBuilder
                .Property(a => a.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(a => a.Name)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
