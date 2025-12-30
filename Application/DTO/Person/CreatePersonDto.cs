namespace Application.DTO.Person
{
    public sealed record CreatePersonDto
    (
        string FirstName,
        string LastName,


        CreatePersonEmailDto? Email,
        CreatePersonPhone? Phone,
        CreatePersonAddressDto? Address
    );
}
