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
    public class AssignedRoleConfig : IEntityTypeConfiguration<AssignedRole>
    { 
        public void Configure(EntityTypeBuilder<AssignedRole> modelBuilder)
        {
            modelBuilder
                .HasKey(ar => ar.Id);

            modelBuilder
                .Property(ar => ar.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .HasIndex(ar => new { ar.AssigneeId, ar.RoleId }) // Composite Index on PersonId and RoleId
                .IsUnique(); // Unique constraint on PersonId and RoleId

            modelBuilder
                .Property(ar => ar.AssignorId)
                .IsRequired();

            modelBuilder
                .Property(ar => ar.AssignedAt)
                .IsRequired();

            modelBuilder
                .HasIndex(ar => ar.AssigneeId)
                .IsUnique()
                .HasFilter("[IsPrimary] = 1"); // Unique index on PersonId where IsPrimary is true



            // Relationships
            modelBuilder
                .HasOne(ar => ar.Assignee)
                .WithMany(p => p.RoleAssignmentsReceived)
                .HasForeignKey(ar => ar.AssigneeId);

            modelBuilder
                .HasOne(ar => ar.Role)
                .WithMany(r => r.AssignedRoles)
                .HasForeignKey(ar => ar.RoleId);

            modelBuilder
                .HasOne(ar => ar.Assignor)
                .WithMany(p => p.RoleAssignmentsMade)
                .HasForeignKey(ar => ar.AssignorId);






        }
    }
}