using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface ICompany : IRepository<Company>
    {
        Task<Company> UpdateAsync(Company company);

        Task<bool> ContainsAsync(Company company);

    }
}
