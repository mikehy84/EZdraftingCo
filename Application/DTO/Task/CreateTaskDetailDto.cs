using System.Runtime.CompilerServices;

namespace Application.DTO.Task
{
    public class CreateTaskDetailDto
    {
        public int Id { get; init; }
        public int TaskNameId { get; init; }
        public string TaskName { get; init; } = string.Empty;
        public int ProjectId { get; init; }
        public string ProjectName { get; init; } = string.Empty;
        public int PhaseId { get; init; }
        public string PhaseName { get; init; } = string.Empty;
        public int AreaId { get; init; }
        public string AreaName { get; init; } = string.Empty;
        public int PriorityId { get; init; }
        public string PriorityName { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public int EstimatedHours { get; init; }
    }
}