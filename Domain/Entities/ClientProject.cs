

namespace Domain.Entities
{
    public class ClientProject
    {
        public int Id { get; set; }
        public string ProjectNo { get; set; }
        public string ProjectName { get; set; }
        public int EstimatedHour { get; set; }
        public decimal ProjectRate { get; set; }
        public string Location { get; set; }
        public DateTime AwardedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }


        // ClientProject is the child in the
        // one-to-many relationship
        public int ClientPmId { get; set; }
        public Person Person { get; set; }


        // ClientProject is the child in the
        // one-to-many relationship
        public int CompanyId { get; set; }
        public Company Company { get; set; }


        // ClientProject is the parent in the
        // one-to-many relationship
        public ICollection<Project> Projects { get; set; } = [];

    }
}
