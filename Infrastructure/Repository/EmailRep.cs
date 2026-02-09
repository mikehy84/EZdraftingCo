
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
    public class EmailRep : Repository<Email>, IEmail
    {
        private readonly ApplicationDbContext _db;

        public EmailRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Email email)
        {
            throw new NotImplementedException();
        }

        public Task<Email> UpdateAsync(Email email)
        {
            throw new NotImplementedException();
        }
    }
}
