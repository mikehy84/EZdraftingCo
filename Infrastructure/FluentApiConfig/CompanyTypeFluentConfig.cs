using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class CompanyTypeFluentConfig : IEntityTypeConfiguration<CompanyType>
    {
        public void Configure(EntityTypeBuilder<CompanyType> modelBuilder)
        {
            modelBuilder
                .HasKey(ct => ct.Id);

            modelBuilder
                .Property(ct => ct.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(ct => ct.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .HasIndex(ct => ct.Name)
                .IsUnique(); // Unique constraint on Name


            // Relationships
            modelBuilder
                .Navigation(ct => ct.Companies);
        }
    }
}
