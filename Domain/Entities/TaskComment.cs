namespace Domain.Entities
{
    public class TaskComment
    {
        public int Id { get; set; }


        // Foreign key to the Person who made the comment
        public int PersonId { get; set; }
        public Person Person { get; set; }


        // Foreign key to the TaskLog that this comment is about
        public int TaskLogId { get; set; }
        public TaskLog TaskLog { get; set; }


        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; }

    }
}