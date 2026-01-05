using Domain.Entities;

namespace Application.Interfaces
{
    public interface ITaskAssignment : IRepository<TaskAssignment>
    {
        Task<TaskAssignment> UpdateAsync(TaskAssignment taskAssignment);

        Task<bool> ContainsAsync(TaskAssignment taskAssignment);
    }
}