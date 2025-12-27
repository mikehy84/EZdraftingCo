using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infrastructure.FluentApiConfig
{
    public class StateFluentConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> modelBuilder)
        {
            modelBuilder
                .HasKey(s => s.Id);

            modelBuilder
                .Property(s => s.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            modelBuilder
                .Property(s => s.Name)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder
                .Property(s => s.Code)
                .IsRequired()
                .HasMaxLength(10);


            // Constraints
            modelBuilder
                .HasIndex(s => new { s.CountryId, s.Name })
                .IsUnique();

            modelBuilder
                .HasIndex(s => new { s.CountryId, s.Code })
                .IsUnique();


            // Relationships
            modelBuilder
                .HasOne(s => s.Country)
                .WithMany(c => c.States)
                .HasForeignKey(s => s.CountryId)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();


            // Navigations
            modelBuilder
                .Navigation(s => s.Addresses);


            // Seeding initial data
            modelBuilder.HasData(
                new State { Id = 1, CountryId = 1, Code = "AB", Name = "Alberta" },
                new State { Id = 2, CountryId = 1, Code = "BC", Name = "British Columbia" },
                new State { Id = 3, CountryId = 1, Code = "MB", Name = "Manitoba" },
                new State { Id = 4, CountryId = 1, Code = "NB", Name = "New Brunswick" },
                new State { Id = 5, CountryId = 1, Code = "NL", Name = "Newfoundland and Labrador" },
                new State { Id = 6, CountryId = 1, Code = "NS", Name = "Nova Scotia" },
                new State { Id = 7, CountryId = 1, Code = "NT", Name = "Northwest Territories" },
                new State { Id = 8, CountryId = 1, Code = "NU", Name = "Nunavut" },
                new State { Id = 9, CountryId = 1, Code = "ON", Name = "Ontario" },
                new State { Id = 10, CountryId = 1, Code = "PE", Name = "Prince Edward Island" },
                new State { Id = 11, CountryId = 1, Code = "QC", Name = "Quebec" },
                new State { Id = 12, CountryId = 1, Code = "SK", Name = "Saskatchewan" },
                new State { Id = 13, CountryId = 1, Code = "YT", Name = "Yukon" },

                new State { Id = 101, CountryId = 2, Code = "AL", Name = "Alabama" },
                new State { Id = 102, CountryId = 2, Code = "AK", Name = "Alaska" },
                new State { Id = 103, CountryId = 2, Code = "AZ", Name = "Arizona" },
                new State { Id = 104, CountryId = 2, Code = "AR", Name = "Arkansas" },
                new State { Id = 105, CountryId = 2, Code = "CA", Name = "California" },
                new State { Id = 106, CountryId = 2, Code = "CO", Name = "Colorado" },
                new State { Id = 107, CountryId = 2, Code = "CT", Name = "Connecticut" },
                new State { Id = 108, CountryId = 2, Code = "DE", Name = "Delaware" },
                new State { Id = 109, CountryId = 2, Code = "FL", Name = "Florida" },
                new State { Id = 110, CountryId = 2, Code = "GA", Name = "Georgia" },
                new State { Id = 111, CountryId = 2, Code = "HI", Name = "Hawaii" },
                new State { Id = 112, CountryId = 2, Code = "ID", Name = "Idaho" },
                new State { Id = 113, CountryId = 2, Code = "IL", Name = "Illinois" },
                new State { Id = 114, CountryId = 2, Code = "IN", Name = "Indiana" },
                new State { Id = 115, CountryId = 2, Code = "IA", Name = "Iowa" },
                new State { Id = 116, CountryId = 2, Code = "KS", Name = "Kansas" },
                new State { Id = 117, CountryId = 2, Code = "KY", Name = "Kentucky" },
                new State { Id = 118, CountryId = 2, Code = "LA", Name = "Louisiana" },
                new State { Id = 119, CountryId = 2, Code = "ME", Name = "Maine" },
                new State { Id = 120, CountryId = 2, Code = "MD", Name = "Maryland" },
                new State { Id = 121, CountryId = 2, Code = "MA", Name = "Massachusetts" },
                new State { Id = 122, CountryId = 2, Code = "MI", Name = "Michigan" },
                new State { Id = 123, CountryId = 2, Code = "MN", Name = "Minnesota" },
                new State { Id = 124, CountryId = 2, Code = "MS", Name = "Mississippi" },
                new State { Id = 125, CountryId = 2, Code = "MO", Name = "Missouri" },
                new State { Id = 126, CountryId = 2, Code = "MT", Name = "Montana" },
                new State { Id = 127, CountryId = 2, Code = "NE", Name = "Nebraska" },
                new State { Id = 128, CountryId = 2, Code = "NV", Name = "Nevada" },
                new State { Id = 129, CountryId = 2, Code = "NH", Name = "New Hampshire" },
                new State { Id = 130, CountryId = 2, Code = "NJ", Name = "New Jersey" },
                new State { Id = 131, CountryId = 2, Code = "NM", Name = "New Mexico" },
                new State { Id = 132, CountryId = 2, Code = "NY", Name = "New York" },
                new State { Id = 133, CountryId = 2, Code = "NC", Name = "North Carolina" },
                new State { Id = 134, CountryId = 2, Code = "ND", Name = "North Dakota" },
                new State { Id = 135, CountryId = 2, Code = "OH", Name = "Ohio" },
                new State { Id = 136, CountryId = 2, Code = "OK", Name = "Oklahoma" },
                new State { Id = 137, CountryId = 2, Code = "OR", Name = "Oregon" },
                new State { Id = 138, CountryId = 2, Code = "PA", Name = "Pennsylvania" },
                new State { Id = 139, CountryId = 2, Code = "RI", Name = "Rhode Island" },
                new State { Id = 140, CountryId = 2, Code = "SC", Name = "South Carolina" },
                new State { Id = 141, CountryId = 2, Code = "SD", Name = "South Dakota" },
                new State { Id = 142, CountryId = 2, Code = "TN", Name = "Tennessee" },
                new State { Id = 143, CountryId = 2, Code = "TX", Name = "Texas" },
                new State { Id = 144, CountryId = 2, Code = "UT", Name = "Utah" },
                new State { Id = 145, CountryId = 2, Code = "VT", Name = "Vermont" },
                new State { Id = 146, CountryId = 2, Code = "VA", Name = "Virginia" },
                new State { Id = 147, CountryId = 2, Code = "WA", Name = "Washington" },
                new State { Id = 148, CountryId = 2, Code = "WV", Name = "West Virginia" },
                new State { Id = 149, CountryId = 2, Code = "WI", Name = "Wisconsin" },
                new State { Id = 150, CountryId = 2, Code = "WY", Name = "Wyoming" },
                new State { Id = 151, CountryId = 2, Code = "DC", Name = "District of Columbia" }
            );
        }
    }
}
