using EZD_DAL.Models;

namespace EZD_DAL.Repository.IRepository
{
    public interface IProject : IRepository<Project>
    {
        Task<Project> UpdateAsync(Project project);

        Task<bool> ContainsAsync(Project project);
    }
}
