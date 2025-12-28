

namespace Domain.Entities
{
    public class EmployeeProfile
    {
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;
        public DateTime? DateOfBirth { get; set; }


        // Job that this Person holds
        public int JobId { get; set; }
        public Job Job { get; set; }


        public decimal RatePerHour { get; set; }



        // Store encrypted SIN (for authorized display)
        public string SinEncrypted { get; set; } = string.Empty;

        // Store a keyed hash for matching/dedup (never display)
        public string SinHash { get; set; } = string.Empty;

        // For UX (“***-***-123”)
        public string SinLast3 { get; set; } = string.Empty;
    }

}
