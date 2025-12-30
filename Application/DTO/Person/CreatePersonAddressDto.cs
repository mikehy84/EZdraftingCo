using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Person
{
    public sealed record CreatePersonAddressDto
    (
        int StateId,
        string StreetNumber,
        string? StreetName,
        string City,
        string? PostalCode,
        bool IsPrimary
    );
}
