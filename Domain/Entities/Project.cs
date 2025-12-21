

namespace Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string InternalProjectNo { get; set; } = string.Empty;


        // Person who is the Project Manager (PM) for this Project
        public int ProjectManagerId { get; set; }
        public Person ProjectManager { get; set; }


        public int ActualHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; } = false;


        // ClientProject that this Project belongs to
        public int ClientProjectId { get; set; }
        public ClientProject ClientProject { get; set; }


        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }


        // Phases that belong to this Project
        public ICollection<Phase> Phases { get; set; } = [];


        // Areas that belong to this Project
        public ICollection<Area> Areas { get; set; } = [];


        // TaskLogs that belong to this Project
        public ICollection<TaskLog> TaskLogs { get; set; } = [];
    }
}
