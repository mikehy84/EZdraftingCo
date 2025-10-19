using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class ClientProjectFluentConfig : IEntityTypeConfiguration<ClientProject>
    {
        public void Configure(EntityTypeBuilder<ClientProject> modelBuilder)
        {
            modelBuilder
                .HasKey(x => x.Id); // Primary Key

            modelBuilder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .HasIndex(x => x.ProjectNo)
                .IsUnique();

            modelBuilder
                .Property(x => x.ProjectName);

            modelBuilder
                .Property(x => x.ProjectRate)
                .HasPrecision(10, 2); // up to 99999999.99

            // Relationships Configuration
            modelBuilder
                .HasOne(x => x.Person)
                .WithMany(x => x.ClientProjects)
                .HasForeignKey(x => x.PersonId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(x => x.Company)
                .WithMany(x => x.ClientProjects)
                .HasForeignKey(x => x.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(x => x.Person);

            modelBuilder
                .Navigation(x => x.Company);
        }
    }
}
