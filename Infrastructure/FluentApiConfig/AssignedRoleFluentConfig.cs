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
    public class AssignedRoleFluentConfig : IEntityTypeConfiguration<AssignedRole>
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
                .Property(ar => ar.AssignedAt)
                .IsRequired();

            modelBuilder
                .HasIndex(ar => ar.AssigneeId)
                .IsUnique()
                .HasFilter("[IsPrimary] = 1"); // Only rows where IsPrimary = true participate in the unique index.



            // Relationships
            modelBuilder
                .HasOne(ar => ar.Assignee)
                .WithMany(person => person.RoleAssignmentsReceived)
                .HasForeignKey(ar => ar.AssigneeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(ar => ar.AppRole)
                .WithMany(r => r.AssignedRoles)
                .HasForeignKey(ar => ar.RoleId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .HasOne(ar => ar.Assignor)
                .WithMany(person => person.RoleAssignmentsMade)
                .HasForeignKey(ar => ar.AssignorId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Seeding initial data
            modelBuilder
                .HasData(
                    new AssignedRole
                    {
                        Id = 1,
                        AssigneeId = 1,
                        RoleId = 1, // Owner
                        AssignorId = 1,
                        AssignedAt = DateTime.UtcNow,
                        IsPrimary = true
                    },
                    new AssignedRole
                    {
                        Id = 2,
                        AssigneeId = 2,
                        RoleId = 2, // Employee
                        AssignorId = 1,
                        AssignedAt = DateTime.UtcNow,
                        IsPrimary = true
                    }
                );
        }
    }
}