using Microsoft.AspNetCore.Http;
using PdfFlipbook_DAL.Models;

namespace PdfFlipbook_BAL.Services.Interfaces
{
    public interface IPdfService
    {
        Task<PdfFile> UploadPdf(IFormFile pdfFile);
        Task<byte[]> GetPdf(string fileName);
    }
}
