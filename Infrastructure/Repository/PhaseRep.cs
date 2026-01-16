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
    public class PhaseRep : Repository<Phase>, IPhase
    {
        private readonly ApplicationDbContext _db;

        public PhaseRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Phase phase)
        {
            throw new NotImplementedException();
        }

        public Task<Phase> UpdateAsync(Phase phase)
        {
            throw new NotImplementedException();
        }
    }
}
