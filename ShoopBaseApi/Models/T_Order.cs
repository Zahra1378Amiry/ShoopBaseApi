using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Order()
        {
            T_Payment = new HashSet<T_Payment>();
            T_TampOrder = new HashSet<T_TampOrder>();
        }

        [Key]
        public long ID_Order { get; set; }

        public long T_User_Id { get; set; }

        public long T_Address_Id { get; set; }

        [Required]
        [StringLength(250)]
        public string OrderStatus { get; set; }

        [Required]
        [StringLength(250)]
        public string SendStatus { get; set; }

        [Required]
        [StringLength(250)]
        public string PaymentStatus { get; set; }

        public bool IsActive { get; set; }

        public virtual T_Address T_Address { get; set; }

        public virtual T_User T_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Payment> T_Payment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampOrder> T_TampOrder { get; set; }
    }
}
