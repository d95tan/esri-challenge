using question_3.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace question_3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;

        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        // Upload file
        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
            {
                return BadRequest("No file uploaded.");
            }

            await _fileService.UploadFileAsync(file);
            return Ok("File uploaded successfully.");
        }

        // Download file
        [HttpGet("download/{fileName}")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            try
            {
                var fileStreamResult = await _fileService.DownloadFileAsync(fileName);
                return fileStreamResult;
            }
            catch (FileNotFoundException)
            {
                return NotFound("File not found.");
            }
        }
    }
}
