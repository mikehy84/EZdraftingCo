using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITaskProgress : IRepository<TaskProgress>
    {
        Task<TaskProgress> UpdateAsync(TaskProgress taskProgress);

        Task<bool> ContainsAsync(TaskProgress taskProgress);
    }
}