using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;


namespace Infrastructure.FluentApiConfig
{
    public class PersonFluentConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> modelBuilder)
        {
            modelBuilder
                .HasKey(p => p.Id); // Primary Key

            modelBuilder
                .Property(p => p.Id)
                .IsRequired()
                .ValueGeneratedOnAdd(); // auto-increment (IDENTITY)

            modelBuilder
                .Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50); // FirstName is required with max length 50

            modelBuilder
                .Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50); // LastName is required with max length 50

            modelBuilder
                .Property(x => x.RatePerHour)
                .IsRequired()
                .HasPrecision(10, 2); // up to 99999999.99


            // Unique constraint
            modelBuilder
                .HasIndex(p => p.AccountId)
                .IsUnique()
                .HasFilter("[AccountId] IS NOT NULL"); // Only rows where AccountId has a value participate in the unique index.


            // Relationships Configuration
            modelBuilder
                .HasOne(p => p.UserAccount)
                .WithOne(ua => ua.Person)
                .HasForeignKey<Person>(p => p.AccountId)
                .IsRequired(false);

            modelBuilder
                .HasOne(p => p.Job)
                .WithMany(j => j.Persons)
                .HasForeignKey(p => p.JobId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder
                .HasOne(p => p.Company)
                .WithMany(c => c.Persons)
                .HasForeignKey(p => p.CompanyId)
                .OnDelete(DeleteBehavior.Restrict);




            // Navigation Properties
            modelBuilder
                .Navigation(p => p.EmployeeProfile);

            modelBuilder
                .Navigation(p => p.RoleAssignmentsReceived);

            modelBuilder
                .Navigation(p => p.RoleAssignmentsMade);

            modelBuilder
                .Navigation(p => p.AccountClaims);

            modelBuilder
                .Navigation(p => p.ClientProjects);

            modelBuilder
                .Navigation(p => p.Projects);

            //modelBuilder
            //    .Navigation(p => p.AssignedTasks);

            //modelBuilder
            //    .Navigation(p => p.ReceivedTasks);

            modelBuilder
                .Navigation(p => p.EmailAddresses);

            modelBuilder
                .Navigation(p => p.PhoneNumbers);

            modelBuilder
                .Navigation(p => p.Addresses);
        }
    }
}
