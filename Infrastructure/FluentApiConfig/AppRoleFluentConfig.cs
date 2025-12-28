using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.FluentApiConfig
{
    public class AppRoleFluentConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> modelBuilder) 
        {
            modelBuilder
                .HasKey(r => r.Id); // Primary Key

            modelBuilder
                .Property(r => r.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(r => r.Name)
                .HasMaxLength(20)
                .IsRequired();


            // Constraints
            modelBuilder
                .HasIndex(r => r.Name)
                .IsUnique(); // Unique constraint on Name


            // Relationships
            modelBuilder
                .Navigation(r => r.AssignedRoles);


            // Seeding initial data
            modelBuilder.HasData(
                new AppRole { Id = 1, Name = "Owner", Description = "Business owner with high-level oversight across all projects." },
                new AppRole { Id = 2, Name = "Employee", Description = "Internal employee involved in project execution and delivery." },
                new AppRole { Id = 3, Name = "Client", Description = "Client-side personnel involved in coordination, review, and approvals." },
                new AppRole { Id = 4, Name = "General Contractor", Description = "Main contractor responsible for overall construction execution." },
                new AppRole { Id = 5, Name = "Subcontractor", Description = "Specialty contractor working under the general contractor." },
                new AppRole { Id = 6, Name = "Vendor", Description = "Material or component supplier participating in coordination." },
                new AppRole { Id = 7, Name = "Fabricator", Description = "Steel fabrication company producing shop components." },
                new AppRole { Id = 8, Name = "Erector", Description = "Company responsible for on-site steel erection." },
                new AppRole { Id = 9, Name = "Consultant", Description = "Engineer, architect, or design consultant." },
                new AppRole { Id = 10, Name = "Inspector", Description = "Third-party or authority inspection role." },
                new AppRole { Id = 11, Name = "ReadOnly", Description = "View-only access with no modification rights." }
            );
        }
    }
}
