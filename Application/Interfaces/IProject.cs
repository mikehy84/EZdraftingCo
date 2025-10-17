using Domain.Entities;

namespace Application.Interfaces
{
    public interface IProject : IRepository<Project>
    {
        Task<Project> UpdateAsync(Project project);

        Task<bool> ContainsAsync(Project project);
    }
}
