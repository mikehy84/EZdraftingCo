using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IPriority : IRepository<Priority>
    {
        Task<Priority> UpdateAsync(Priority priority);

        Task<bool> ContainsAsync (Priority priority);
    }
}
