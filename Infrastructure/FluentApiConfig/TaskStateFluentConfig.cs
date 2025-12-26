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
    public class TaskStateFluentConfig : IEntityTypeConfiguration<Domain.Entities.TaskStatus>
    {
        public void Configure(EntityTypeBuilder<Domain.Entities.TaskStatus> modelBuilder)
        {
            modelBuilder
                .HasKey(ts => ts.Id);

            modelBuilder
                .Property(ts => ts.Id)
                .IsSparse()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(ts => ts.Name)
                .IsRequired()
                .HasMaxLength(20);

            modelBuilder
                .HasIndex(ts => ts.Name)
                .IsUnique();

            // Navigation Properties
            modelBuilder
                .Navigation(ts => ts.TaskLogs);
        }
    }
}
