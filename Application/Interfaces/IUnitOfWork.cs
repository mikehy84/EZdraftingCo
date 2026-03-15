using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IUnitOfWork
    {
        IAccountClaim AccountClaims { get; }
        IAddress Addresses { get; }
        ICompany Companies { get; }
        IEmail Emails { get; }
        IPerson Persons { get; }
        IPhase Phases { get; }
        IPhone Phones { get; }
        IProject Projects { get; }
        IProjectArea ProjectAreas { get; }
        IPriority Priorities { get; }
        ITaskAssignment TaskAssignments { get; }
        ITaskDetail TaskDetails { get; }
        ITaskName TaskNames { get; }
        ITaskProgress TaskProgresses { get; }
        IUserAccount UserAccounts { get; }

        Task Save();
    }
}
