using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BaiKiemTra03_02.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public DateTime Publicationyear { get; set; }
        [Required]
        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public required string Genre { get; set; }
    }
}
