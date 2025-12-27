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
                .HasKey(c => c.Id);

            modelBuilder
                .Property(c => c.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(c => c.Name)
                .HasMaxLength(100)
                .IsRequired();


            // Indexes Configuration amd Unique Constraints
            modelBuilder
                .HasIndex(c => c.Name)
                .IsUnique(); // Unique Index on Name




            // Relationships Configuration
            modelBuilder
                .HasOne(c => c.CompanyType)
                .WithMany(ct => ct.Companies)
                .HasForeignKey(c => c.CompanyTypeId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder
                .Navigation(c => c.ClientProjects);

            modelBuilder
                .Navigation(c => c.Persons);
        }
    }
}
