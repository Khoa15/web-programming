using System.ComponentModel.DataAnnotations;

namespace Bai2.Models
{
    public class Information
    {
        [Required()]
        [StringLength(50)]
        public string FullName { get; set; }
        [Required()]
        [StringLength(10, ErrorMessage ="Nhập chiều dài không quá 10 ký số")]
        public string IdStudent { get; set; }
        [Required(ErrorMessage ="Bắt buộc nhập địa chỉ Email")]
        [EmailAddress(ErrorMessage ="Địa chỉ email không hợp lệ")]
        public string Email { get; set; }
        public string FileImage { get; set; }
        public string Note { get; set; }
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }

        public string ChooseWorkTime { get; set; }
        [Required()]
        public string SelectCourse { get; set; }
    }
}
