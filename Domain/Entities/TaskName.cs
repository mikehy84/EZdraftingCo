

namespace Domain.Entities
{
    public class TaskName
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // TaskDetails associated with this Task
        public ICollection<TaskDetail> TaskDetails { get; set; } = [];
    }
}
