

namespace Domain.Entities
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;



        // TaskLogs that have this Priority
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
