using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITaskDetail : IRepository<TaskDetail>
    {
        Task<TaskDetail> UpdateAsync(TaskDetail taskDetail);

        Task<bool> ContainsAsync(TaskDetail taskDetail);
    }
}