using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AppRole
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // "Employee", "ClientContact", "VendorRep", "AppUser"
        public string Description { get; set; } = string.Empty;


        // AssignedRoles that belong to this Role
        public ICollection<AssignedRole> AssignedRoles { get; set; } = [];
    }

}