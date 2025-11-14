

namespace Domain.Entities
{
    public class Phase
    {
        public int Id { get; set; }
        public int PhaseNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }


        // Phase is the child in the
        // one-to-many relationship
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        // Phase is the parent in the
        // one-to-many relationship
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
