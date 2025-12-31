
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
    public class EmailAddressRep : Repository<EmailAddress>, IEmailAddress
    {
        private readonly ApplicationDbContext _db;

        public EmailAddressRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(EmailAddress emailAddress)
        {
            throw new NotImplementedException();
        }

        public Task<EmailAddress> UpdateAsync(EmailAddress emailAddress)
        {
            throw new NotImplementedException();
        }
    }
}
