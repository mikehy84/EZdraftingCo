using Application.DTO.Person;
using Application.DTO.TaskProgress;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.TaskAssignment
{
    //this is Task log
    public class TaskAssignmentDto
    {
        public int Id { get; init; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; init; } = string.Empty;

        [Display(Name = "Priority")]
        public string PriorityName { get; init; } = string.Empty;

        [Display(Name = "Assignee")]
        public string AssigneeName { get; set; } = null!;
        public string Title { get; init; } = string.Empty;

        [Display(Name = "Estimated Hours")]
        public int EstimatedHours { get; init; }

        [Display(Name = "Spent Hours")]
        public double SpentHours { get; init; }

        [Display(Name = "Status")]
        public string TaskStateName { get; init; } = string.Empty;

        public DateTime CreatedAt { get; set; }

        public List<TaskProgressDto> TaskProgresses { get; init; } = [];
    }
}
