namespace Application.DTO.Person
{
    public sealed record CreatePersonDto
    {
        public string FirstName { get; init; } = string.Empty;
        public string LastName { get; init; } = string.Empty;

        public CreatePersonEmailDto? Email { get; init; }
        public CreatePersonPhoneDto? Phone { get; init; }
        public CreatePersonAddressDto? Address { get; init; }
    }
}
