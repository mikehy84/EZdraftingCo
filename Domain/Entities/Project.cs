using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string InternalProjectNo { get; set; }
        public int ActualHours { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsClosed { get; set; } = false;
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }



        // Project is the child in the
        // one-to-many relationship
        public int ClientProjectId { get; set; }
        public ClientProject ClientProject { get; set; }




        // Project is the child in the
        // one-to-many relationship
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
