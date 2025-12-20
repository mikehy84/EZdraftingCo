

namespace Domain.Entities
{
    public class TaskState
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // Navigation property for the related TaskLogs
        // TaskState is the parent in the one-to-many relationship
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
