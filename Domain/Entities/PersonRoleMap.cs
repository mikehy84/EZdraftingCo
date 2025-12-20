using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PersonRoleMap
    {
        public int Id { get; set; }

        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;


        // PersonRoleMap is the child in the one-to-many relationship
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;


        // Audit fields
        public DateTime AssignedAt { get; set; }


        // PersonRoleMap is the child in the one-to-many relationship
        public int? AssignedByPersonId { get; set; }
        public Person AssignedByPerson { get; set; }

        public bool IsPrimary { get; set; }
    }
}
