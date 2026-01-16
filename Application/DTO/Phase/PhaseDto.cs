using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTO.Phase
{
    public class PhaseDto
    {
        public int Id { get; init; }
        public int ProjectId { get; init; }
        public int PhaseNumber { get; init; }
        public string PhaseName { get; init; } = string.Empty;
        public string Comment { get; init; } = string.Empty;
    }
}
