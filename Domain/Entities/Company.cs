using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;


        // Company is the cild in the
        // one-to-many relationship
        public int CategoryId { get; set; }
        public CompanyCategory CompanyCategory { get; set; }


        // Company is the parent in the
        // one-to-many relationship
        public List<Person> Persons { get; set; } = new();


        // Company is the parent in the
        // one-to-many relationship
        public List<ClientProject> ClientProjects { get; set; } = new();



    }
}
