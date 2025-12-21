

namespace Domain.Entities
{
    public class TaskLog
    {
        public int Id { get; set; }


        // Project that this TaskLog belongs to
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        // Person who assigned the task to someone
        public int AssignorId { get; set; }
        public Person Assignor { get; set; }


        // Person who this task is assigned to
        public int AssigneeId { get; set; }
        public Person Assignee { get; set; }


        // Phase that this TaskLog belongs to
        public int PhaseId { get; set; }
        public Phase Phase { get; set; }


        // Are that this TaskLog belongs to
        public int AreaId { get; set; }
        public Area Area { get; set; }


        // Task that this TaskLog is about
        public int TaskId { get; set; }
        public TaskName Task { get; set; }


        public string Description { get; set; } = string.Empty;


        // Proiority that this TaskLog has
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }


        public DateTime DueDate { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishAt { get; set; }
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
        public int CompletionPercentage { get; set; }
        public string Comment { get; set; } = string.Empty;


        // TaskState that this TaskLog is in
        public int StatusId { get; set; }
        public TaskState TaskStatus { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
