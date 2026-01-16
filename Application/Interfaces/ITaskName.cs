using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITaskName : IRepository<TaskName>
    {
        Task<TaskName> UpdateAsync(TaskName taskName);

        Task<bool> ContainsAsync(TaskName taskName);
    }
}