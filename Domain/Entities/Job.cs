using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Job
    {
        public int Id { get; set; } 
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal RatePerHour { get; set; }


        // Job is the parent in the
        // one-to-many relationship
        public List<Person> Persons { get; set; } = new();
    }
}
