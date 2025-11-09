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
    public class UserAccountRep : Repository<UserAccount>, IUserAccount
    {
        private readonly ApplicationDbContext _db;

        public UserAccountRep(ApplicationDbContext db) 
            : base(db)
        {
            _db = db;
        }

        public Task<bool> ContainsAsync(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }

        public Task<UserAccount> UpdateAsync(UserAccount userAccount)
        {
            throw new NotImplementedException();
        }

        //public async Task<AppUser> UpdateAsync(AppUser appUser)
        //{

        //    _db.AppUsers.Update(appUser);
        //    await SaveAsync();
        //    return appUser;
        //}

        //public async Task<bool> ContainsAsync(AppUser appUser)
        //{
        //    if (appUser == null)
        //        throw new ArgumentNullException(nameof(appUser));

        //    return await _db.AppUsers.AnyAsync(p => p.Email.Equals(appUser.Email));
        //}

    }
}
