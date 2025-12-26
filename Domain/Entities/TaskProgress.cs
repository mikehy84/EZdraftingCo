

namespace Domain.Entities
{
    public class TaskProgress
    {
        public int Id { get; set; }


        // Project that this TaskLog belongs to
        public int TaskAssignmentId { get; set; }
        public TaskAssignment TaskAssignment { get; set; }


        public DateTime Date { get; set; }
        public double SpentHours { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }


        // TaskComments associated with this TaskLog
        public ICollection<TaskComment> TaskComments { get; set; } = [];
    }
}
