using Microsoft.EntityFrameworkCore;

namespace EFW;

public class BookDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Book> Books { get; set; }
    public DbSet<BookCopy> BookCopies { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Cấu hình chuỗi kết nối MySQL với mật khẩu của bạn
        optionsBuilder.UseMySQL("server=localhost;port=3306;database=BookDb;user=root;password=dmcvmkii28;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Khai báo quan hệ: 1 Category có nhiều Book (Slide 18)
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Category)
            .WithMany(c => c.Books)
            .HasForeignKey(b => b.CategoryId);

        // Khai báo quan hệ: 1 Book có nhiều BookCopy (Slide 18)
        modelBuilder.Entity<BookCopy>()
            .HasOne(bc => bc.Book)
            .WithMany(b => b.BookCopies)
            .HasForeignKey(bc => bc.BookId);
    }
}
