using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class ProjectFluentConfig : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> modelBuilder)
        {
            modelBuilder
                .HasKey(x => x.Id); // Primary Key

            modelBuilder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .HasIndex(x => x.InternalProjectNo)
                .IsUnique();

            modelBuilder
                .Property(x => x.InternalProjectNo)
                .IsRequired();

            modelBuilder
                .HasIndex(a => new {a.InternalProjectNo, a.ClientProjectId })
                .IsUnique();

            // Relationships Configuration
            modelBuilder
                .HasOne(x => x.Person)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.PmId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(x => x.ClientProject)
                .WithMany(x => x.Projects)
                .HasForeignKey(x => x.ClientProjectId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(x => x.Person);

            modelBuilder
                .Navigation(x => x.ClientProject);
        }
    }
}
