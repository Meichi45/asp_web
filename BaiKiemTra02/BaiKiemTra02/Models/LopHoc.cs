using System.ComponentModel.DataAnnotations;
namespace BaiKiemTra02.Models
{
    public class LopHoc
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string TenLopHoc {  get; set; }
        [Required]
        public DateTime NamNhapHoc { get; set; }
        [Required]
        public DateTime NamRaTruong { get; set; }
        [Required]
        public int SoLuongSinhVien { get; set; }
    }
}
