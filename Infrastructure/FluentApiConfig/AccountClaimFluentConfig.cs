using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class AccountClaimFluentConfig : IEntityTypeConfiguration<AccountClaim>
    {
        public void Configure(EntityTypeBuilder<AccountClaim> modelBuilder)
        {
            modelBuilder
                .HasKey(ac => ac.Id); // Primary Key

            modelBuilder
                .Property(ac => ac.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(ac => ac.TokenHash)
                .IsRequired();

            modelBuilder
                .HasIndex(ac => ac.TokenHash)
                .IsUnique(); // Unique Index
        }
    }
}