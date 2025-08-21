using System.ComponentModel.DataAnnotations;

namespace LibraryManagerMVC_2212447.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Tên danh mục")]
        public string CategoryName { get; set; } = string.Empty;

        [StringLength(500)]
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }

        // Navigation property for one-to-many relationship
        public virtual ICollection<Book> Books { get; set; } = new List<Book>();
    }
}