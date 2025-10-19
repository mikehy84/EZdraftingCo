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
        public string SIN { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public List<ClientProject> ClientProjects { get; set; } = new();



        // Person is the parent in the
        // one-to-many relationship
        public List<Project> Projects { get; set; } = new();
    }
}
