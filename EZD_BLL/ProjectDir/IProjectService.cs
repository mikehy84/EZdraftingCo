using EZD_DAL.Models;
using Microsoft.AspNetCore.JsonPatch;


namespace EZD_BLL.ProjectDir
{
    public interface IProjectService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<ApiResponse> CreateAsync(T model);
        Task<ApiResponse> DeleteAsync(int id);
        Task<T> UpdateAsync(int id, T model);
        Task<ApiResponse> UpdatePartialAsync(int id, JsonPatchDocument<T> model);
    }
}
