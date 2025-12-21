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
                .HasKey(ar => ar.Id); // Primary Key

            modelBuilder
                .Property(ar => ar.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .HasIndex(ar => new { ar.PersonId, ar.RoleId }); // Composite Index on PersonId and RoleId

            modelBuilder
                .Property(ar => ar.AssignedAt)
                .IsRequired();

            modelBuilder
                .Property(ar => ar.AssignedByPersonId)
                .IsRequired();

            // Relationships
            modelBuilder
                .HasOne(ar => ar.Person)
                .WithMany(p => p.AssignedRoles)
                .HasForeignKey(ar => ar.PersonId); 



        }
    }
}