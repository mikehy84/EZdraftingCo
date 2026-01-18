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
    public class ProjectAreaRep : Repository<ProjectArea>, IProjectArea
    {
        private readonly ApplicationDbContext _db;

        public ProjectAreaRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(ProjectArea projectArea)
        {
            throw new NotImplementedException();
        }

        public Task<ProjectArea> UpdateAsync(ProjectArea projectArea)
        {
            throw new NotImplementedException();
        }
    }
}
