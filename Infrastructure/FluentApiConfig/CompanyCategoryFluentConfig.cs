using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class CompanyCategoryFluentConfig : IEntityTypeConfiguration<CompanyCategory>
    {
        public void Configure(EntityTypeBuilder<CompanyCategory> modelBuilder)
        {
            modelBuilder
                .HasKey(x => x.Id); // Primary Key

            modelBuilder
                .Property(x => x.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}
