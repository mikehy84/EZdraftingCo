

namespace Domain.Entities
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; }



        // Priority is the parent in the
        // one-to-many relationship
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
