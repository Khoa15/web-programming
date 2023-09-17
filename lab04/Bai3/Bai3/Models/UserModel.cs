using System.ComponentModel.DataAnnotations;

namespace Bai3.Models
{
    public class UserModel
    {
        [Required()]
        [StringLength(50)]
        public string Name { get; set; }
        [Required()]
        [StringLength(100)]
        public string Email { get; set; }
        [Required()]
        public string Password { get; set; }
        [Required(ErrorMessage = "'ConfirmPassword' and 'Password' do not match")]
        public string ReTypePassword { get; set; }
        public bool RememberMe { get; set; }
    }
}
