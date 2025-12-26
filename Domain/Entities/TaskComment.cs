namespace Domain.Entities
{
    public class TaskComment
    {
        public int Id { get; set; }


        // Foreign key to the Person who made the comment
        public int TaskProgressId { get; set; }
        public TaskProgress TaskProgress { get; set; }


        public string Comment { get; set; } = string.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; }
    }
}