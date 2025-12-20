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
                .HasKey(cp => cp.Id); // Primary Key

            modelBuilder
                .Property(cp => cp.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .HasIndex(cp => cp.ProjectName)
                .IsUnique();

            modelBuilder
                .Property(cp => cp.ProjectName);

            modelBuilder
                .Property(cp => cp.ProjectRate)
                .HasPrecision(10, 2); // up to 99999999.99

            // Relationships Configuration
            modelBuilder
                .HasOne(p => p.Person)
                .WithMany(cp => cp.ClientProjects)
                .HasForeignKey(cp => cp.ClientPmId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(p => p.Person);

            modelBuilder
                .HasOne(c => c.Company)
                .WithMany(cp => cp.ClientProjects)
                .HasForeignKey(cp => cp.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(c => c.Company);
        }
    }
}
