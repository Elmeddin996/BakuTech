
using Microsoft.AspNetCore.Http;
using BakuTech.Web.Models;

namespace BakuTech.Web.Services;

public interface IFileService
{
    Task<FileUploadResult> UploadAsync(
        IFormFile? file,
        string folderName,
        string? fileName = null);

    Task DeleteAsync(string? filePath);
}
