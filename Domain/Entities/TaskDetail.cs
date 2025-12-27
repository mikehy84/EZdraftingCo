



namespace Domain.Entities
{
    public class TaskDetail
    {
        public int Id { get; set; }


        // Task that this TaskDetail is about
        public int TaskNameId { get; set; }
        public TaskName TaskName { get; set; }


        // Project that this TaskLog belongs to
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        // Phase that this TaskLog belongs to
        public int PhaseId { get; set; }
        public Phase Phase { get; set; }


        // Are that this TaskLog belongs to
        public int AreaId { get; set; }
        public ProjectArea Area { get; set; }


        // Proiority that this TaskLog has
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }


        public string Description { get; set; } = string.Empty;
        public int EstimatedHours { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }


        // TaskLog that this TaskDetail belongs to
        public TaskLog TaskLog { get; set; }


        // TaskAssignments associated with this TaskDetail
        public ICollection<TaskAssignment> TaskAssignments { get; set; } = [];
    }
}
