

namespace Domain.Entities
{
    public class TaskLog
    {
        public int Id { get; set; }


        // Project that this TaskLog belongs to
        public int TaskDetailId { get; set; }
        public TaskDetail TaskDetail { get; set; }


        // TaskState that this TaskLog is in
        public int StatusId { get; set; }
        public TaskStatus TaskStatus { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
