

namespace Application.DTO.Person
{
    public class PersonDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;

        public DateTime DateOfBirth { get; set; }

        public string? AccountId { get; set; }

        public int JobId { get; set; }
        public string? JobTitle { get; set; }

        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
    }

}
