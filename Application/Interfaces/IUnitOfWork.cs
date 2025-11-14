using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        IPriority Priorities { get; }
        IProject Projects { get; }
        IUserAccount UserAccounts { get; }

        Task Save();
    }
}
