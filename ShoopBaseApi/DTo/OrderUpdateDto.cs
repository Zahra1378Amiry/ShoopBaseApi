using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class OrderUpdateDto
    {
        [Key]
        public long ID_Order { get; set; }

        public long T_User_Id { get; set; }

        public long T_Address_Id { get; set; }

        [Required(ErrorMessage = " وضعبت سفارش را وارد کنید ")]
        [StringLength(250)]
        public string OrderStatus { get; set; }

        [Required(ErrorMessage = " وضغیت ارسال را وارد کنید ")]
        [StringLength(250)]
        public string SendStatus { get; set; }

        [Required(ErrorMessage = " وصغیت پرداخت را وارد کنید ")]
        [StringLength(250)]
        public string PaymentStatus { get; set; }

        public bool IsActive { get; set; }

        public virtual T_Address T_Address { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
