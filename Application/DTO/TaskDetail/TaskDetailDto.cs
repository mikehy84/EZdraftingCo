using Application.DTO.TaskAssignment;
using Application.DTO.TaskProgress;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.TaskDetail
{
    public class TaskDetailDto
    {
        public int Id { get; init; }
        public string ProjectName { get; init; } = string.Empty;
        public string AssigneeName { get; set; } = null!;
        public string PriorityName { get; init; } = string.Empty;
        public string Title { get; init; } = string.Empty;
        public string Description { get; init; } = string.Empty;
        public int EstimatedHours { get; init; }
        public string SpentHours { get; init; } = string.Empty;
        public string TaskStateName { get; init; } = string.Empty;
        public List<TaskAssignmentDto> TaskAssignments { get; init; } = [];
    }
}
