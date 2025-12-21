
namespace Domain.Entities
{
    public class AssignedRole
    {
        public int Id { get; set; }

        // Person who the role is assigned to
        public int PersonId { get; set; }
        public Person Person { get; set; } = null!;


        // Role that is assigned to the person
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;


        // Audit fields
        // Person who assigned the role
        public int AssignedByPersonId { get; set; }
        public Person AssignedByPerson { get; set; }


        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        

        public bool IsPrimary { get; set; }
    }
}
