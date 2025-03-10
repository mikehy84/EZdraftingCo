using EZD_DAL;
using EZD_DAL.Data;
using EZD_DAL.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZD_DAL.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public IProject Projects { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Projects = new ProjectRep(_db);
        }


        public async Task Save()
        {
            await _db.SaveChangesAsync();
        }
    }
}
