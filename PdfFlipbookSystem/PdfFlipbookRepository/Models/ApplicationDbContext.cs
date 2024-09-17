using Microsoft.EntityFrameworkCore;

namespace PdfFlipbookRepository.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<PdfFile> PdfFiles { get; set; }
    }
}
