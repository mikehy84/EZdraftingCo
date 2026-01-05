using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        IAddress Addresses { get; }
        IEmailAddress EmailAddresses { get; }
        IPerson Persons { get; }
        IPhone Phones { get; }
        IProject Projects { get; }
        IPriority Priorities { get; }
        ITaskAssignment TaskAssignments { get; }
        ITaskDetail TaskDetails { get; }
        IUserAccount UserAccounts { get; }

        Task Save();
    }
}
