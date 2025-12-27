
namespace Domain.Entities
{
    public class ProjectArea
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // Area is the child in the one-to-many relationship
        // FK (child → parent) => The child table stores the foreign key that points to the parent table.
        // One Project ➜ Many Areas
        // Each Area belongs to exactly one Project
        // ------------------------------------------------------------
        // Project that this Area belongs to
        public int ProjectId { get; set; }
        public Project Project { get; set; }


        // TaskDetails that belong to this Area
        public ICollection<TaskDetail> TaskDetails { get; set; } = [];

    }
}
