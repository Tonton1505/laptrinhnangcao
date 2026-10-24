using System.ComponentModel.DataAnnotations;

namespace EFW;

public class Category
{
    [Key] // Khóa chính
    public int CategoryId { get; set; } // Mã
    public string Description { get; set; } = string.Empty; // Mô tả

    // 1 category có nhiều Book
    public ICollection<Book> Books { get; set; }

    public Category()
    {
        Books = new List<Book>();
    }
}
