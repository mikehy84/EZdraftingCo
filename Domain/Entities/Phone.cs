using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Phone
    {
        public int Id { get; set; }

        // Foreign key to PhoneType
        public int PhoneTypeId { get; set; }
        public PhoneType PhoneType { get; set; }


        // Foreign key to Person
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public string PhoneNumber { get; set; }
        public bool IsPrimary { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
