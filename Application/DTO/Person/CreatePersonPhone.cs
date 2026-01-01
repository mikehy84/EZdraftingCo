using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Person
{
    public sealed record CreatePersonPhoneDto
    {
        public int TypeId { get; init; }
        public int CountryId { get; init; }
        public string PhoneNumber { get; init; } = string.Empty;
        public bool IsPrimary { get; init; }
    }
}
