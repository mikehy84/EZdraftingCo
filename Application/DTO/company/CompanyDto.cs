using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.company
{
    public sealed record CompanyDto
    {
        public int Id { get; init; }
        public string Name { get; init; } = string.Empty;
        public string CompanyType { get; init; }
    }
}
