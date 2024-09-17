using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PdfFlipbookRepository.Models
{
    public class PdfFile
    {
        public int Id { get; set; }  // ID cho việc truy xuất dễ dàng
        public string ileName { get; set; }
        public string FilePath { get; set; }
        public DateTime UploadedAt { get; set; }
        // Thêm thông tin khác nếu cần
    }
}
