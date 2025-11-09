using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.FluentApiConfig
{
    public class TaskStateFluentConfig : IEntityTypeConfiguration<TaskState>
    {
        public void Configure(EntityTypeBuilder<TaskState> modelBuilder)
        {
            modelBuilder
                .HasKey(u => u.Id);

            modelBuilder
                .Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(30);

            modelBuilder
                .HasIndex(u => u.Name)
                .IsUnique();
        }
    }
}
