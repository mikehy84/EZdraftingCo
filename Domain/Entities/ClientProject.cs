

namespace Domain.Entities
{
    public class ClientProject
    {
        public int Id { get; set; }


        // Person who is the client project manager
        public int? ClientPmId { get; set; }
        public Person ClientPm { get; set; }


        // Company that this project belongs to
        public int CompanyId { get; set; }
        public Company Company { get; set; }


        public string ProjectNo { get; set; } = string.Empty;
        public string ProjectName { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public int EstimatedHour { get; set; }
        public decimal ProjectRate { get; set; }
        public DateTime AwardedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }


        // Projects under this ClientProject
        public ICollection<Project> Projects { get; set; } = [];

    }
}
