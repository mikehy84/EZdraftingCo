

namespace Domain.Entities
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;



        // Priority is the parent in the
        // one-to-many relationship
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
