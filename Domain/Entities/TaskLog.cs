using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class TaskLog
    {
        public int Id { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }

        public int AssignorId { get; set; }
        public Person Assignor { get; set; }

        public int AssigneeId { get; set; }
        public Person Assignee { get; set; }

        public int AreaId { get; set; }
        public Area Area { get; set; }

        public int TaskId { get; set; }
        public Task Task { get; set; }

        public int PhaseId { get; set; }
        public Phase Phase { get; set; }

        public string Description { get; set; }

        public int PriorityId { get; set; }
        public Priority Priority { get; set; }


        public DateTime DueDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int EstimatedHour { get; set; }
        public int ActualHour { get; set; }
        public int CompletionPercentage { get; set; }
        public bool IsDone { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;






    }
}
