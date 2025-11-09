

namespace Domain.Entities
{
    public class TaskName
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // TaskName is the parent in the
        // one-to-many relationship
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
