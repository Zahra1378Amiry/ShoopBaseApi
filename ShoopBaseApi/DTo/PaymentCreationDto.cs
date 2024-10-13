using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class PaymentCreationDto
    {
        [Key]
        public long ID_Payment { get; set; }

        public long ID_User_Id { get; set; }

        public decimal PaymentAmount { get; set; }

        [Required(ErrorMessage = " تحوه پرداخت را وارد کنید ")]
        [StringLength(50)]
        public string PaymentMethod { get; set; }

        [Required(ErrorMessage = " وضعیت پرداخت را وارد کنید ")]
        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public DateTime PaymentDate { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        [Required(ErrorMessage = " شماره تراکنش را وارد کنید ")]
        [StringLength(150)]
        public string TransactionCode { get; set; }

        public long T_Order_Id { get; set; }

        public bool IsActive { get; set; }

        public virtual T_Order T_Order { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
