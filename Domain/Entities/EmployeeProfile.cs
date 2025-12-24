

#nullable enable // Enable nullable reference types

namespace Domain.Entities
{
    public class EmployeeProfile
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;

        // Store encrypted SIN (for authorized display)
        public string? SinEncrypted { get; set; }

        // Store a keyed hash for matching/dedup (never display)
        public string? SinHash { get; set; }

        // For UX (“***-***-123”)
        public string? SinLast3 { get; set; }
    }

}
