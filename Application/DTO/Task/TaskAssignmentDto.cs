using Application.DTO.Person;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Task
{
    public class TaskAssignmentDto
    {
        public int Id { get; init; }
        public string ProjectName { get; init; } = string.Empty;
        public string PriorityName { get; init; } = string.Empty;
        public string AssigneeName { get; set; } = null!;
        public string Title { get; init; } = string.Empty;
        public int EstimatedHours { get; init; }
        public double SpentHours { get; init; } 
        public string TaskStateName { get; init; } = string.Empty;

        public List<TaskProgressDto> TaskProgresses { get; init; } = [];
    }
}
