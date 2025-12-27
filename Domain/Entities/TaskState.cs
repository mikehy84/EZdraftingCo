

namespace Domain.Entities
{
    public class TaskState
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;



        // TaskLogs that have this TaskStatus
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
