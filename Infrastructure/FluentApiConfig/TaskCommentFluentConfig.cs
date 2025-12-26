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
    public class TaskCommentFluentConfig : IEntityTypeConfiguration<TaskComment>
    {
        public void Configure(EntityTypeBuilder<TaskComment> modelBuilder)
        {
            modelBuilder
                .HasKey(tc => tc.Id);

            modelBuilder
                .Property(tc => tc.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(tc => tc.Comment)
                .IsRequired()
                .HasMaxLength(1000);

            // Relationships
            modelBuilder
                .HasOne(tc => tc.TaskProgress)
                .WithMany(tp => tp.TaskComments)
                .HasForeignKey(tc => tc.TaskProgressId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
