using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class CompanyFluentConfig : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> modelBuilder)
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


            // Relationships Configuration
            modelBuilder
                .HasOne(x => x.CompanyCategory)
                .WithMany(x => x.Companies)
                .HasForeignKey(x => x.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .Navigation(x => x.CompanyCategory);
        }
    }
}
