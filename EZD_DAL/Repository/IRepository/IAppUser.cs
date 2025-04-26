using EZD_DAL.Models;

namespace EZD_DAL.Repository.IRepository
{
    public interface IAppUser : IRepository<AppUser>
    {
        Task<AppUser> UpdateAsync(AppUser appUser);

        Task<bool> ContainsAsync(AppUser appUser);
    }
}
