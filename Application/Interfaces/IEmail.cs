using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEmail : IRepository<Email>
    {
        Task<Email> UpdateAsync(Email email);

        Task<bool> ContainsAsync(Email email);

    }
}
