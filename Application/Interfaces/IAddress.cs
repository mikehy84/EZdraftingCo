using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IAddress : IRepository<Address>
    {
        Task<Address> UpdateAsync(Address address);

        Task<bool> ContainsAsync(Address address);

    }
}
