
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
    public class PhoneRep : Repository<Phone>, IPhone
    {
        private readonly ApplicationDbContext _db;

        public PhoneRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Phone phone)
        {
            throw new NotImplementedException();
        }

        public Task<Phone> UpdateAsync(Phone phone)
        {
            throw new NotImplementedException();
        }
    }
}
