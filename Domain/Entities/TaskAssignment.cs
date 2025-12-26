

namespace Domain.Entities
{
    public class TaskAssignment
    {
        public int Id { get; set; }


        // Project that this TaskLog belongs to
        public int TaskDetailId { get; set; }
        public TaskDetail TaskDetail { get; set; }


        // Person who assigned the task to someone
        public int AssignorId { get; set; }
        public Person Assignor { get; set; }


        // Person who this task is assigned to
        public int AssigneeId { get; set; }
        public Person Assignee { get; set; }


        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; }


        // Progress updates related to this task assignment
        public ICollection<TaskProgress> TaskProgresses { get; set; } = [];
    }
}
