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
    public class UserAccountFluentConfig : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> modelBuilder)
        {
            modelBuilder
                .HasOne(ua => ua.Person)
                .WithOne(p => p.UserAccount)
                .HasForeignKey<Person>(p => p.AccountId)
                .IsRequired(false); // optional one-to-one


            // Navigation properties
            modelBuilder
                .Navigation(ua => ua.Person);
        }
    }
}
