

namespace Domain.Entities
{
    public class TaskStatus
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // TaskLogs that are in this TaskState
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
