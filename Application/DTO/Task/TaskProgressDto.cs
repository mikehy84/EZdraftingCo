namespace Application.DTO.Task
{
    public class TaskProgressDto
    {
        public int Id { get; init; }
        public int TaskAssignmentId { get; init; }
        public DateTime EntryDate { get; init; }
        public double SpentHours { get; init; }
    }
}