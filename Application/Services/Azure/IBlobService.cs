using Microsoft.AspNetCore.Http;


namespace Application.Services.Azure
{
    public interface IBlobService
    {
        Task<string> GetBlob(string blobName, string containerName);
        Task<bool> DeleteBlob(string blobName, string containerName);
        Task<List<string>> UploadBlob(string containerName, List<IFormFile> files);
    }
}
