using PdfFlipbook_DAL.Models;


namespace PdfFlipbook_DAL.Repositories.Interfaces
{
    public interface IPdfRepository
    {
        Task<PdfFile> AddAsync(PdfFile pdfFile);
        Task<PdfFile> GetByIdAsync(int id);
        Task<PdfFile> GetByFileNameAsync(string fileName);
    }
}
