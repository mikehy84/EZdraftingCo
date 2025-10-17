using Domain.Entities;
using Microsoft.AspNetCore.JsonPatch;


namespace Application.Services.AppUserDir
{
    public interface IAppUserService<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(string id);
        Task<ApiResponse> CreateAsync(T model);
        Task<ApiResponse> DeleteAsync(string id);
        Task<T> UpdateAsync(string id, T model);
        Task<ApiResponse> UpdatePartialAsync(string id, JsonPatchDocument<T> model);
    }
}
