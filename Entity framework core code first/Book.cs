using System.ComponentModel.DataAnnotations;

namespace EFW;

public class Book
{
    [Key] // Khóa chính
    public int BookId { get; set; } // Mã
    public string Title { get; set; } = string.Empty; // Tiêu đề
    public string? Publisher { get; set; } // Nhà xuất bản
    public decimal Price { get; set; } // Giá thành
    public int TotalCopies { get; set; } // Số bản sao
    public string? Author { get; set; } // Tác giả
    public int PublicationYear { get; set; } // Năm xuất bản

    // Khóa ngoại liên kết tới Category (1 Category có nhiều Book)
    public int CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    // 1 book có nhiều BookCopy
    public ICollection<BookCopy> BookCopies { get; set; }

    public Book()
    {
        BookCopies = new List<BookCopy>();
    }
}
