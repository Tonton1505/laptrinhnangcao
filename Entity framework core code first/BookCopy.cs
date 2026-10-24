using System.ComponentModel.DataAnnotations;

namespace EFW;

public class BookCopy
{
    [Key] // Khóa chính
    public int BookCopyId { get; set; } // Mã bookCopy
    public string Status { get; set; } = string.Empty; // Trạng thái
    public string Condition { get; set; } = string.Empty; // Tình trạng

    // Khóa ngoại liên kết tới Book (1 Book có nhiều BookCopy)
    public int BookId { get; set; }
    public Book Book { get; set; } = null!;
}
