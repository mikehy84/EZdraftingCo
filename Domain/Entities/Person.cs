using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string SIN { get; set; } = string.Empty; // Social Insurance Number
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public DateTime DateOfBirth { get; set; }


        // Person is the child in the
        // one-to-many relationship
        public int JobId { get; set; }
        public Job Job { get; set; }


        // Person is the child in the
        // one-to-many relationship
        public int CompanyId { get; set; }
        public Company Company { get; set; }



        // Person is the parent in the
        // one-to-many relationship
        public ICollection<ClientProject> ClientProjects { get; set; } = [];



        // Person is the parent in the
        // one-to-many relationship
        public ICollection<Project> Projects { get; set; } = [];


        // Person is the parent in the
        // one-to-many relationship

        // Tasks this person assigned to others
        public ICollection<TaskLog> AssignedTasks { get; set; } = [];

        // Tasks assigned to this person
        public ICollection<TaskLog> ReceivedTasks { get; set; } = [];
    }
}
