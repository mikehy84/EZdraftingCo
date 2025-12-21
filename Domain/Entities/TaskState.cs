

namespace Domain.Entities
{
    public class TaskState
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;



        // TaskLogs that are in this TaskState
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
