using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IEmailAddress : IRepository<EmailAddress>
    {
        Task<EmailAddress> UpdateAsync(EmailAddress emailAddress);

        Task<bool> ContainsAsync(EmailAddress emailAddress);

    }
}
