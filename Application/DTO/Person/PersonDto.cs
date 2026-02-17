

namespace Application.DTO.Person
{
    public sealed record PersonDto
    {
        // init meaning: “This property can be set only during object creation, not later.”
        public int Id { get; init; }
        public int CompanyId { get; init; }
        public string? CompanyName { get; init; }
        public string Name { get; init; } = string.Empty;
        public string Phone { get; init; } = string.Empty;
        public string Email { get; init; } = string.Empty;
        public string AccountId { get; init; } = string.Empty;
    }
}