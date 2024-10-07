using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_02.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Nationnality { get; set; }
        [Required]
        public DateTime BirthYear { get; set; }
    }
}
