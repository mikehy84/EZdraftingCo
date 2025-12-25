using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string AlphaCode { get; set; } = string.Empty;
        public string PhoneCode { get; set; } = string.Empty;

        // States or Provinces within this country
        public ICollection<State> States { get; set; } = [];

        public ICollection<Phone> Phones { get; set; } = [];
    }
}
