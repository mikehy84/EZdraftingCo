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
                new AppRole { Id = 1, Name = "SystemAdmin", Description = "Full system administration and configuration access." },
                new AppRole { Id = 2, Name = "Internal Project Manager", Description = "Manages projects, assignments, schedules, and client coordination." },
                new AppRole { Id = 3, Name = "Detailer", Description = "Creates and maintains Tekla models and detailing deliverables." },
                new AppRole { Id = 4, Name = "Drafter", Description = "Produces shop drawings, annotations, and drawing revisions." },
                new AppRole { Id = 5, Name = "Checker", Description = "Reviews and checks models and drawings for quality and compliance." },
                new AppRole { Id = 6, Name = "Client Coordinator", Description = "Coordinates detailing output with fabrication requirements." },
                new AppRole { Id = 7, Name = "Client Project Manager", Description = "Client-side manager responsible for approvals and project oversight." },
                new AppRole { Id = 8, Name = "Read Only", Description = "View-only access to projects and documents." },
                new AppRole { Id = 9, Name = "Owner", Description = "Business or company owner with high-level oversight across projects and operations." }
            );
        }
    }
}
