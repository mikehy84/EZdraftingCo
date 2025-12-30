using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Person
{
    public sealed record CreatePersonPhone
    (
        int TypeId,
        int CountryId,
        string PhoneNumber,
        bool IsPrimary
    );
}
