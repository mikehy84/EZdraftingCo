using Application.DTO.TaskAssignment;
using Application.DTO.TaskDetail;
using Application.DTO.TaskProgress;

namespace Application.DTO.Project
{
    public class ProjectDto
    {
        public int Id { get; init; }
        public string InternalProjectNo { get; init; } = string.Empty;
        public string ProjectManagerName { get; init; } = string.Empty;
        public int ActualHours { get; init; }
        public bool IsClosed { get; init; } = false;
        public string ClientProjectName { get; init; } = string.Empty;
        public string ClientPmName { get; init; } = string.Empty;
    }
}
