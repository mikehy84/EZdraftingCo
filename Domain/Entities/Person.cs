

#nullable enable // Enable nullable reference types

namespace Domain.Entities
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public DateTime? DeactivatedAt { get; set; }
        public DateTime? ReactivatedAt { get; set; }




        // optional foreign key to the ASP.NET Identity user
        public string? AccountId { get; set; }
        public UserAccount? UserAccount { get; set; }



        // Company that this Person belongs to
        public int? CompanyId { get; set; }
        public Company? Company { get; set; }



        // PhoneNumbers associated with this person
        public ICollection<Phone> PhoneNumbers { get; set; } = [];


        // Addresses associated with this person
        public ICollection<Address> Addresses { get; set; } = [];


        // EmployeeProfile for this person
        public EmployeeProfile? EmployeeProfile { get; set; }  // one-to-one


        // Role thats are assigned to this person
        public ICollection<AssignedRole> RoleAssignmentsReceived { get; set; } = [];


        // Role that this person has assigned to others
        public ICollection<AssignedRole> RoleAssignmentsMade { get; set; } = [];


        // AccountClaims associated with this person
        public ICollection<AccountClaim> AccountClaims { get; set; } = [];


        // EmailAddresses associated with this person
        public ICollection<EmailAddress> EmailAddresses { get; set; } = [];


        // Tasks this person assigned to others
        public ICollection<TaskAssignment> AssignedTasks { get; set; } = [];


        // Tasks assigned to this person
        public ICollection<TaskAssignment> ReceivedTasks { get; set; } = [];


        // Projects this person manages
        public ICollection<Project> Projects { get; set; } = [];


        // ClientProjects that are being managed by this person
        public ICollection<ClientProject> ClientProjects { get; set; } = [];
    }
}
