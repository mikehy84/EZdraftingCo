
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
    public class AddressRep : Repository<Address>, IAddress
    {
        private readonly ApplicationDbContext _db;

        public AddressRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Address address)
        {
            throw new NotImplementedException();
        }

        public Task<Address> UpdateAsync(Address address)
        {
            throw new NotImplementedException();
        }
    }
}
