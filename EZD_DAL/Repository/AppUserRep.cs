using EZD_DAL.Data;
using EZD_DAL.Models;
using EZD_DAL.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZD_DAL.Repository
{
    public class AppUserRep : Repository<AppUser>, IAppUser
    {
        private readonly ApplicationDbContext _db;

        public AppUserRep(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<AppUser> UpdateAsync(AppUser appUser)
        {

            _db.AppUsers.Update(appUser);
            await SaveAsync();
            return appUser;
        }

        public async Task<bool> ContainsAsync(AppUser appUser)
        {
            if (appUser == null)
                throw new ArgumentNullException(nameof(appUser));

            return await _db.AppUsers.AnyAsync(p => p.Email.Equals(appUser.Email));
        }

    }
}
