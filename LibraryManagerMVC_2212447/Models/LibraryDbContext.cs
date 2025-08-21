using Microsoft.EntityFrameworkCore;

namespace LibraryManagerMVC_2212447.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure one-to-many relationship
            modelBuilder.Entity<Book>()
                .HasOne(b => b.Category)
                .WithMany(c => c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            // Seed initial data
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Khoa học", Description = "Sách về khoa học và công nghệ" },
                new Category { CategoryId = 2, CategoryName = "Văn học", Description = "Sách văn học và tiểu thuyết" },
                new Category { CategoryId = 3, CategoryName = "CNTT", Description = "Sách về công nghệ thông tin và lập trình" },
                new Category { CategoryId = 4, CategoryName = "Kinh tế", Description = "Sách về kinh tế và quản lý" },
                new Category { CategoryId = 5, CategoryName = "Lịch sử", Description = "Sách về lịch sử và văn hóa" }
            );

            modelBuilder.Entity<Book>().HasData(
                new Book { BookId = 1, Title = "Lập trình C# cơ bản", Author = "Nguyễn Văn A", ISBN = "978-123456789", PublishedYear = 2023, CategoryId = 3 },
                new Book { BookId = 2, Title = "Truyện Kiều", Author = "Nguyễn Du", ISBN = "978-987654321", PublishedYear = 1820, CategoryId = 2 },
                new Book { BookId = 3, Title = "Vật lý đại cương", Author = "Trần Văn B", ISBN = "978-111222333", PublishedYear = 2022, CategoryId = 1 },
                new Book { BookId = 4, Title = "Quản lý dự án", Author = "Lê Thị C", ISBN = "978-444555666", PublishedYear = 2021, CategoryId = 4 },
                new Book { BookId = 5, Title = "Lịch sử Việt Nam", Author = "Phạm Văn D", ISBN = "978-777888999", PublishedYear = 2020, CategoryId = 5 }
            );
        }
    }
}