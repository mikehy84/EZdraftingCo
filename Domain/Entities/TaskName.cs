

namespace Domain.Entities
{
    public class TaskName
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // TaskLogs that have this TaskName
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
