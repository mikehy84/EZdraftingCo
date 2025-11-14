

namespace Domain.Entities
{
    public class TaskLog
    {
        public int Id { get; set; }


        // TaskLog is the child in the
        // one-to-many relationship
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        // TaskLog is the child in the
        // many-to-one relationship
        public int AssignorId { get; set; }
        public Person Assignor { get; set; }


        // TaskLog is the child in the
        // one-to-many relationship
        public int AssigneeId { get; set; }
        public Person Assignee { get; set; }


        // TaskLog is the child in the
        // one-to-many relationship
        public int PhaseId { get; set; }
        public Phase Phase { get; set; }


        // TaskLog is the child in the
        // one-to-many relationship
        public int AreaId { get; set; }
        public Area Area { get; set; }


        // TaskLog is the child in the
        // one-to-many relationship
        public int TaskId { get; set; }
        public TaskName Task { get; set; }


        


        public string Description { get; set; } = string.Empty;


        // TaskLog is the child in the
        // one-to-many relationship
        public int PriorityId { get; set; }
        public Priority Priority { get; set; }


        public DateTime DueDate { get; set; }
        public DateTime StartedAt { get; set; }
        public DateTime FinishAt { get; set; }
        public int EstimatedHours { get; set; }
        public int ActualHours { get; set; }
        public int CompletionPercentage { get; set; }
        public string Comment { get; set; } = string.Empty;



        // TaskLog is the child in the
        // one-to-many relationship
        public int StatusId { get; set; }
        public TaskState TaskState { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
