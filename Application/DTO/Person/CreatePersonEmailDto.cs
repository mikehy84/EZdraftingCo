using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Person
{
    public sealed record CreatePersonEmailDto
    {
        public string Email { get; init; } = string.Empty;
        public bool IsPrimary { get; init; }
    }
}
