
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IAccountClaim AccountClaims { get; private set; }
        public IAddress Addresses { get; private set; }
        public ICompany Companies { get; private set; }
        public IEmail Emails { get; private set; }
        public IPerson Persons { get; private set; }
        public IPhase Phases { get; private set; }
        public IPhone Phones { get; private set; }
        public IPriority Priorities { get; set; }
        public IProject Projects { get; private set; }
        public IProjectArea ProjectAreas { get; private set; }
        public ITaskAssignment TaskAssignments { get; private set; }
        public ITaskDetail TaskDetails { get; private set; }
        public ITaskName TaskNames { get; private set; }
        public IUserAccount UserAccounts { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            AccountClaims = new AccountClaimRep(_db); 
            Addresses = new AddressRep(_db);
            Companies = new CompanyRep(_db);
            Emails = new EmailRep(_db);
            Persons = new PersonRep(_db);
            Phases = new PhaseRep(_db);
            Phones = new PhoneRep(_db);
            Priorities = new PriorityRep(_db);
            Projects = new ProjectRep(_db);
            ProjectAreas = new ProjectAreaRep(_db);
            TaskAssignments = new TaskAssignmentRep(_db);
            TaskDetails = new TaskDetailRep(_db);
            TaskNames = new TaskNameRep(_db);
            UserAccounts = new UserAccountRep(_db);
        }


        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
