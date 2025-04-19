using Microsoft.AspNetCore.Http;


namespace EZD_BLL.Services
{
    public interface IBlobService
    {
        Task<string> GetBlob(string blobName, string containerName);
        Task<bool> DeleteBlob(string blobName, string containerName);
        Task<List<string>> UploadBlob(string containerName, List<IFormFile> files);
    }
}
