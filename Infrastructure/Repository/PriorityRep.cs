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
    public class PriorityRep : Repository<Priority>, IPriority
    {
        private readonly ApplicationDbContext _db;

        public PriorityRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Priority priority)
        {
            throw new NotImplementedException();
        }

        public Task<Priority> UpdateAsync(Priority priority)
        {
            throw new NotImplementedException();
        }
    }
}
