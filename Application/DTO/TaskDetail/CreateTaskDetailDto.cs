using System.Runtime.CompilerServices;

namespace Application.DTO.TaskDetail
{
    public class CreateTaskDetailDto
    {
        public int Id { get; init; }
        public int TaskNameId { get; init; }
        public int ProjectId { get; init; }
        public int PhaseId { get; init; }
        public int? AreaId { get; init; }
        public int PriorityId { get; init; }
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public int EstimatedHours { get; init; }


        // optional
        public int? AssignorId { get; init; }
        public int? AssigneeId { get; init; }
    }
}