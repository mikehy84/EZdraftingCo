using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAppUser : IRepository<AppUser>
    {
        Task<AppUser> UpdateAsync(AppUser appUser);

        Task<bool> ContainsAsync(AppUser appUser);
    }
}
