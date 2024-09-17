

namespace PdfFlipbook_DAL.Models
{
    public class PdfFile
    {
        public int Id { get; set; }  // ID cho việc truy xuất dễ dàng
        public required string FileName { get; set; }
        public required string FilePath { get; set; }
        public DateTime UploadedAt { get; set; }
        // Thêm thông tin khác nếu cần
    }
}
