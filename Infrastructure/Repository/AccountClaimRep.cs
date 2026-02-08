
using Application.Interfaces;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AccountClaimRep : Repository<AccountClaim>, IAccountClaim
    {
        private readonly ApplicationDbContext _db;

        public AccountClaimRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(AccountClaim accountClaim)
        {
            throw new NotImplementedException();
        }

        public Task<AccountClaim> UpdateAsync(AccountClaim accountClaim)
        {
            throw new NotImplementedException();
        }
    }
}
