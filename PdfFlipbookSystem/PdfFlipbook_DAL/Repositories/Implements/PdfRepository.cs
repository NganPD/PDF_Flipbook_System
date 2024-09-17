using Microsoft.EntityFrameworkCore;
using PdfFlipbook_DAL.Models;
using PdfFlipbook_DAL.Data;
using PdfFlipbook_DAL.Repositories.Interfaces;

namespace PdfFlipbook_DAL.Repositories.Implements
{
    internal class PdfRepository : IPdfRepository
    {
        private readonly ApplicationDbContext _context;

        public PdfRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<PdfFile> AddAsync(PdfFile pdfFile)
        {
            _context.PdfFiles.Add(pdfFile);
            await _context.SaveChangesAsync();
            return pdfFile;
        }

        public async Task<PdfFile> GetByFileNameAsync(string fileName)
        {
            var pdfFile = await _context.PdfFiles
                .FirstOrDefaultAsync(p => p.FileName == fileName);

            if (pdfFile == null)
            {
                // Có thể ném ra ngoại lệ hoặc trả về giá trị mặc định tùy theo yêu cầu của bạn
                throw new KeyNotFoundException($"No PdfFile found with the file name '{fileName}'.");
            }

            return pdfFile;
        }

        public async Task<PdfFile> GetByIdAsync(int id)
        {
            var pdfFile = await _context.PdfFiles.FindAsync(id);

            if (pdfFile == null)
            {
                // Có thể ném ra ngoại lệ hoặc trả về giá trị mặc định tùy theo yêu cầu của bạn
                throw new KeyNotFoundException($"No PdfFile found with the ID '{id}'.");
            }

            return pdfFile;
        }
    }
}
