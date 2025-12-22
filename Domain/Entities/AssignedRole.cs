
namespace Domain.Entities
{
    public class AssignedRole
    {
        public int Id { get; set; }

        // Person who the role is assigned to
        public int AssigneeId { get; set; }
        public Person Assignee { get; set; } = null!;


        // Role that is assigned to the person
        public int RoleId { get; set; }
        public Role Role { get; set; } = null!;


        // Audit fields
        // Person who assigned the role
        public int AssignorId { get; set; }
        public Person Assignor { get; set; }


        public DateTime AssignedAt { get; set; } = DateTime.UtcNow;
        

        public bool IsPrimary { get; set; }
    }
}
