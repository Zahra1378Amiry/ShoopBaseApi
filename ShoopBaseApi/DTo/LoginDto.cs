using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class LoginDto
    {
        [Required(ErrorMessage = "نام کاربری را وارد کنید")]
        [StringLength(100)]
        public string UserName { get; set; }

        [Required(ErrorMessage = "پسورد را وارد کنید")]
        [StringLength(100)]
        public string Password { get; set; }
    }
}

