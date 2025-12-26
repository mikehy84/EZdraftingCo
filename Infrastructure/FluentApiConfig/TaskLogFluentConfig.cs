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
    public class TaskLogFluentConfig : IEntityTypeConfiguration<TaskLog>
    {
        public void Configure(EntityTypeBuilder<TaskLog> modelBuilder)
        {
            modelBuilder
                .HasKey(tl => tl.Id);

            modelBuilder
                .Property(tl => tl.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();


            // Relationships
            modelBuilder
                .HasOne(tl => tl.TaskDetail)
                .WithOne(td => td.TaskLog)
                .HasForeignKey<TaskLog>(tl => tl.TaskDetailId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            modelBuilder
                .HasOne(tl => tl.TaskStatus)
                .WithMany(ts => ts.TaskLogs)
                .HasForeignKey(tl => tl.StatusId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
