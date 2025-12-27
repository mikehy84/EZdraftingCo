using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class CompanyTypeFluentConfig : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> modelBuilder)
        {
            modelBuilder
                .HasKey(ct => ct.Id);

            modelBuilder
                .Property(ct => ct.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(ct => ct.Type)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .HasIndex(ct => ct.Type)
                .IsUnique(); // Unique constraint on Name


            // Relationships
            modelBuilder
                .Navigation(ct => ct.Companies);


            // Seeding initial data
            modelBuilder.HasData(
                new CompanyType { Id = 1, Type = "Internal", Comment = "Our own company or internal branches" },
                new CompanyType { Id = 2, Type = "Client", Comment = "Project owner or paying client" },
                new CompanyType { Id = 3, Type = "General Contractor", Comment = "Main contractor responsible for construction" },
                new CompanyType { Id = 4, Type = "Steel Fabricator", Comment = "Fabrication shop producing steel members" },
                new CompanyType { Id = 5, Type = "Steel Erector", Comment = "Company responsible for site erection" },
                new CompanyType { Id = 6, Type = "Consultant", Comment = "Engineering, architectural, or design consultant" },
                new CompanyType { Id = 7, Type = "Vendor", Comment = "Material or component supplier" },
                new CompanyType { Id = 8, Type = "Subcontractor", Comment = "Specialty contractor under main contract" },
                new CompanyType { Id = 9, Type = "Inspector", Comment = "Third-party or authority inspection body" },
                new CompanyType { Id = 10, Type = "Authority", Comment = "Regulatory or permitting authority" },
                new CompanyType { Id = 11, Type = "Partner", Comment = "Strategic or long-term collaborator" },
                new CompanyType { Id = 12, Type = "Logistics", Comment = "Transport / delivery companies" }
            );
        }
    }
}
