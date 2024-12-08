using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace question_3.Services
{
    public class FileService : IFileService
    {
        // Existing method for downloading a file
        public async Task<FileStreamResult> DownloadFileAsync(string fileName)
        {
            var filePath = Path.Combine("Uploads", fileName);

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("File not found.", filePath);
            }

            var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            return await Task.FromResult(new FileStreamResult(stream, "application/octet-stream")
            {
                FileDownloadName = fileName
            });
        }

        // New method for uploading a file
        public async Task UploadFileAsync(IFormFile file)
        {
            var uploadDirectory = "Uploads";

            // Ensure the directory exists
            if (!Directory.Exists(uploadDirectory))
            {
                Directory.CreateDirectory(uploadDirectory);
            }

            // Combine the directory and file name to get the full path
            var filePath = Path.Combine(uploadDirectory, file.FileName);

            // Save the file to the specified path
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
        }
    }
}
