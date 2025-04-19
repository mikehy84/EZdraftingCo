using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;


namespace EZD_BLL.Services
{
    public class BlobService: IBlobService
    {
        private readonly BlobServiceClient _blobServiceClient;
        private readonly string _defaultContainer;

        public BlobService(BlobServiceClient blobServiceClient, IOptions<AzureStorageSettings> settings)
        {
            _blobServiceClient = blobServiceClient;
            _defaultContainer = settings.Value.ContainerName;
        }

        public async Task<bool> DeleteBlob(string blobName, string containerName)
        {
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = blobContainerClient.GetBlobClient(blobName);

            return await blobClient.DeleteIfExistsAsync();
        }

        public async Task<string> GetBlob(string blobName, string containerName)
        {
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient =  blobContainerClient.GetBlobClient(blobName);

            return blobClient.Uri.AbsoluteUri;
        }

        public async Task<List<string>> UploadBlob(string containerName, List<IFormFile> files)
        {
            var uploadedUrls = new List<string>();
            var allowedContentType = "image/webp";
            var allowedExtension = ".webp";

            // Blob Container Setup
            BlobContainerClient blobContainerClient = _blobServiceClient.GetBlobContainerClient(containerName);
            await blobContainerClient.CreateIfNotExistsAsync();
            blobContainerClient.SetAccessPolicy(PublicAccessType.Blob);

            foreach (var file in files)
            {
                if (file.Length > 0)
                {

                    var extension = Path.GetExtension(file.FileName).ToLowerInvariant();
                    var contentType = file.ContentType.ToLowerInvariant();

                    if (extension != allowedExtension || contentType != allowedContentType)
                        continue; // Skip invalid file

                    var uniqueBlobName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                    // Uploading File to Azure
                    BlobClient blobClient = blobContainerClient.GetBlobClient(uniqueBlobName);

                    var httpHeaders = new BlobHttpHeaders
                    {
                        ContentType = file.ContentType
                    };

                    await blobClient.UploadAsync(file.OpenReadStream(), httpHeaders);

                    // Collecting Uploaded URLs
                    // Stores the public URL of the uploaded blob in a list.
                    uploadedUrls.Add(blobClient.Uri.ToString());
                }
            }

            // Returns a list of all uploaded file URLs
            // which can be stored into database or displayed in the app.
            return uploadedUrls;
        }

    }
}
