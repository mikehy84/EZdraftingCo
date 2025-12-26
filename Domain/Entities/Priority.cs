

namespace Domain.Entities
{
    public class Priority
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;



        // TaskDetails that have this Priority
        public ICollection<TaskDetail> TaskDetails { get; set; } = [];
    }
}
