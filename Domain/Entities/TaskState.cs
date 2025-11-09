

namespace Domain.Entities
{
    public class TaskState
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // Navigation property for the related TaskLogs
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
