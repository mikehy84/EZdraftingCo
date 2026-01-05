

namespace Domain.Entities
{
    public class TaskState
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;



        // TaskDetails that have this TaskStatus
        public ICollection<TaskDetail> TaskDetails { get; set; } = [];
    }
}
