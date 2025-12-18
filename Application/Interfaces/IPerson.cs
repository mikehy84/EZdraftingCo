using AutoMapper;
using Domain.Entities;

namespace Application.Interfaces
{
    public interface IPerson : IRepository<Person>
    {
        Task<Person> UpdateAsync(Person person);

        Task<bool> ContainsAsync(Person person);

    }
}
