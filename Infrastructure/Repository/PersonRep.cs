
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
    public class PersonRep : Repository<Person>, IPerson
    {
        private readonly ApplicationDbContext _db;

        public PersonRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(Person person)
        {
            throw new NotImplementedException();
        }

        public Task<Person> UpdateAsync(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
