

#nullable enable // Enable nullable reference types

namespace Domain.Entities
{
    public class EmployeeProfile
    {
        // PK + FK to Person
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        public string? SIN { get; set; }  // Sensitive data
    }
}
