using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAccountClaim : IRepository<AccountClaim>
    {
        Task<AccountClaim> UpdateAsync(AccountClaim accountClaim);

        Task<bool> ContainsAsync(AccountClaim accountClaim);

    }
}
