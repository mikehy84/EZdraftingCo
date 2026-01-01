using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Person
{
    public sealed record CreatePersonAddressDto
    {
        public int StateId { get; init; }

        public string StreetNumber { get; init; } = string.Empty;

        public string? StreetName { get; init; }

        public string City { get; init; } = string.Empty;

        public string? PostalCode { get; init; }

        public bool IsPrimary { get; init; }
    }

}
