using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PhoneType
    {
        public int Id { get; set; }
        public string Type { get; set; }


        // PhoneNumbers associated with this PhoneType
        public ICollection<Phone> Phones { get; set; } = [];
    }
}
