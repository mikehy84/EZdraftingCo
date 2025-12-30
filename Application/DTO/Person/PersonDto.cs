

namespace Application.DTO.Person
{
    public sealed record PersonDto
    (
        int Id,
        string FirstName,
        string LastName,
        string? AccountId,
        int CompanyId,
        string? CompanyName
    );
}
