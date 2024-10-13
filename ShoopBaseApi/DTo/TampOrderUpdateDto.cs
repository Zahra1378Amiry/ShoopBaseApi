using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class TampOrderUpdateDto
    {
        [Key]
        public long ID_TampOrder { get; set; }

        public long T_User_Id { get; set; }

        public long T_Address_Id { get; set; }

        [Required(ErrorMessage = " وضعیت سفارش  را وارد کنید ")]
        [StringLength(50)]
        public string OrderStatus { get; set; }

        [Required(ErrorMessage = " وضغیت ارسال را وارد کنید ")]
        [StringLength(50)]
        public string SendStatus { get; set; }

        [Required(ErrorMessage = " وضعیت پرداخت را وارد کنید ")]
        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public bool IsActive { get; set; }

        public long T_Order_Id { get; set; }

        public virtual T_Address T_Address { get; set; }

        public virtual T_Order T_Order { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
