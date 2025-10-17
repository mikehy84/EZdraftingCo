
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
        public IAppUser AppUsers { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Projects = new ProjectRep(_db);
            AppUsers = new AppUserRep(_db);
        }


        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
