

namespace Domain.Entities
{
    public class Phase
    {
        public int Id { get; set; }


        // Project that this Phase belongs to
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        public int PhaseNumber { get; set; }
        public string PhaseName { get; set; } = string.Empty;
        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }


        // TaskDetails associated with this Phase
        public ICollection<TaskDetail> TaskDetails { get; set; } = [];
    }
}
