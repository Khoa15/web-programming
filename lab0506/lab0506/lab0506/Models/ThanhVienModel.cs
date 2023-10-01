using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lab0506.Models
{
    public class ThanhVienModel
    {
        [Key]
        public int MaTV { get; set; }
        [Required]
        public string Ten { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string MatKhau { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string NLMatKhau { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public ThanhVienModel()
        {
            Ten = String.Empty;
            MatKhau = String.Empty;
            Email = String.Empty;
            NLMatKhau = String.Empty;
        }

        public ThanhVienModel(int maTV, string ten, string matKhau, string nLMatKhau, string email)
        {
            MaTV = maTV;
            Ten = ten;
            MatKhau = matKhau;
            NLMatKhau = nLMatKhau;
            Email = email;
        }
    }
}
