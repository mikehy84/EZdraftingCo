using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPhone : IRepository<Phone>
    {
        Task<Phone> UpdateAsync(Phone phone);

        Task<bool> ContainsAsync(Phone phone);

    }
}
