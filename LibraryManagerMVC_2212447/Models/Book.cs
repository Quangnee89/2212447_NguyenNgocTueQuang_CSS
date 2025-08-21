using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagerMVC_2212447.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }

        [Required]
        [StringLength(200)]
        [Display(Name = "Tựa sách")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [Display(Name = "Tác giả")]
        public string Author { get; set; } = string.Empty;

        [Required]
        [StringLength(20)]
        [Display(Name = "Mã ISBN")]
        public string ISBN { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Năm xuất bản")]
        [Range(1000, 2100, ErrorMessage = "Năm xuất bản phải từ 1000 đến 2100")]
        public int PublishedYear { get; set; }

        [Required]
        [Display(Name = "Danh mục")]
        public int CategoryId { get; set; }

        // Navigation property for foreign key relationship
        [ForeignKey("CategoryId")]
        public virtual Category? Category { get; set; }
    }
}