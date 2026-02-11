
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
    public class CompanyRep : Repository<Company>, ICompany
    {
        private readonly ApplicationDbContext _db;

        public CompanyRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Company company)
        {
            throw new NotImplementedException();
        }

        public Task<Company> UpdateAsync(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
