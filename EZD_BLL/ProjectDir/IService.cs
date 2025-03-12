using EZD_DAL.Models;
using Microsoft.AspNetCore.JsonPatch;


namespace EZD_BLL.ProjectDir
{
    public interface IService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<ApiResponse> GetByIdAsync(int id);
        Task<ApiResponse> CreateAsync(T model);
        Task<ApiResponse> DeleteAsync(int id);
        Task<ApiResponse> UpdateAsync(int id, T model);
        Task<ApiResponse> UpdatePartialAsync(int id, JsonPatchDocument<T> model);
    }
}
