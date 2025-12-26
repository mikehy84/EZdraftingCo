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
    public class TaskProgressFluentConfig : IEntityTypeConfiguration<TaskProgress>
    {
        public void Configure(EntityTypeBuilder<TaskProgress> modelBuilder)
        {
            modelBuilder
                .HasKey(tp => tp.Id);

            modelBuilder
                .Property(tp => tp.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(tp => tp.Date)
                .IsRequired();

            modelBuilder
                .Property(tp => tp.SpentHours)
                .IsRequired();

            // Relationships
            modelBuilder
                .HasOne(tp => tp.TaskAssignment)
                .WithMany(ta => ta.TaskProgresses)
                .HasForeignKey(tp => tp.TaskAssignmentId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            // Navigation properties
            modelBuilder
                .Navigation(tp => tp.TaskComments);
        }
    }
}
