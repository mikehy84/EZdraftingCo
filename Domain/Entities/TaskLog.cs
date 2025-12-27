

namespace Domain.Entities
{
    public class TaskLog
    {
        public int Id { get; set; }


        // Foreign Key to TaskDetail
        public int TaskDetailId { get; set; }
        public TaskDetail TaskDetail { get; set; }


        // Foreign Key to TaskStatus
        public int TaskStateId { get; set; }
        public TaskState TaskState { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }
    }
}
