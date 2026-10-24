using EFW;

Console.WriteLine("=== KIỂM TRA KẾT NỐI VÀ ÁNH XẠ DATABASE (CODE-FIRST) ===");

using (var context = new BookDbContext())
{
    // 1. Thêm mới một Category (Slide 50)
    var itCategory = new Category
    {
        Description = "Công nghệ thông tin"
    };

    // 2. Thêm mới một Book thuộc Category trên
    var csharpBook = new Book
    {
        Title = "Lập trình C# và Entity Framework Core",
        Publisher = "NXB Giáo Dục",
        Price = 125000,
        TotalCopies = 10,
        Author = "Nguyen Van A",
        PublicationYear = 2026,
        Category = itCategory
    };

    // 3. Thêm mới một BookCopy thuộc cuốn sách trên
    var copy1 = new BookCopy
    {
        Status = "Có sẵn",
        Condition = "Mới 100%",
        Book = csharpBook
    };

    context.Categories.Add(itCategory);
    context.Books.Add(csharpBook);
    context.BookCopies.Add(copy1);
    context.SaveChanges();

    Console.WriteLine("=> Đã thêm dữ liệu thành công vào MySQL Database!");

    // 4. Truy vấn lại dữ liệu (Slide 53, 54)
    var books = context.Books.ToList();
    Console.WriteLine($"=> Số lượng sách hiện có trong DB: {books.Count}");
    foreach (var b in books)
    {
        Console.WriteLine($"   - [Mã: {b.BookId}] {b.Title} | Giá: {b.Price:N0} VNĐ | Tác giả: {b.Author}");
    }
}
