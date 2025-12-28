

namespace Application.DTO.Person
{
    public class PersonDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? AccountId { get; set; }
        public int CompanyId { get; set; }
        public string? CompanyName { get; set; }
    }

}
