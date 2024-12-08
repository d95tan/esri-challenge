using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace question_3.Services
{
    public interface IFileService
    {
        // Existing method for downloading a file
        Task<FileStreamResult> DownloadFileAsync(string fileName);

        // Add the new method for uploading a file
        Task UploadFileAsync(IFormFile file);
    }
}
