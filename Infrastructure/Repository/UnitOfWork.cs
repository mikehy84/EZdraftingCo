
using Application.Interfaces;
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

        public IProject Projects { get; private set; }
        public IUserAccount UserAccounts { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Projects = new ProjectRep(_db);
            UserAccounts = new UserAccountRep(_db);
        }


        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
