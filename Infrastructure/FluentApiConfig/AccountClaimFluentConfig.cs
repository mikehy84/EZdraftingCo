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

            modelBuilder
                .HasIndex(ac => ac.PersonId)
                .IsUnique() // Unique Index
                .HasFilter("[IsActive] = 1"); // Only rows where IsActive = true participate in the unique index.


            // Relationships
            modelBuilder
                .HasOne(ac => ac.Person)
                .WithMany(p => p.AccountClaims)
                .HasForeignKey(ac => ac.PersonId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}