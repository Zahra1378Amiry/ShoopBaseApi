using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class SendEmailUpdateDto
    {
        [Key]
        public long ID_SendEmail { get; set; }

        public long T_User_Id { get; set; }

        [Required(ErrorMessage = " آدرس ایمیل را وارد کنید ")]
        [StringLength(150)]
        public string EmailAdrress { get; set; }

        [StringLength(250)]
        public string Subject { get; set; }

        [StringLength(350)]
        public string Body { get; set; }

        [StringLength(150)]
        public string SentStatus { get; set; }

        public DateTime SendDate { get; set; }

        public DateTime? CreatedAt { get; set; }

        public bool IsActive { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
