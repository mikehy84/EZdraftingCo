
namespace Domain.Entities
{
    public class Area
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // Area is the child in the
        // one-to-many relationship
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        // Area is the parent in the
        // one-to-many relationship
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
