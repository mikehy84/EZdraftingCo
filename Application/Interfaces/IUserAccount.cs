using Domain.Entities;

namespace Application.Interfaces
{
    public interface IUserAccount : IRepository<UserAccount>
    {
        Task<UserAccount> UpdateAsync(UserAccount userAccount);

        Task<bool> ContainsAsync(UserAccount userAccount);
    }
}
