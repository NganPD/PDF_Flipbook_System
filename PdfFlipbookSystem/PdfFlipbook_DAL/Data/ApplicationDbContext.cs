using Microsoft.EntityFrameworkCore;
using PdfFlipbook_DAL.Models;


namespace PdfFlipbook_DAL.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }

        public DbSet<PdfFile> PdfFiles { get; set; }
    }
}
