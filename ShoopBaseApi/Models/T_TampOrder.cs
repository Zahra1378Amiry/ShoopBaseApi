using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_TampOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_TampOrder()
        {
            T_TampShoppingBasket = new HashSet<T_TampShoppingBasket>();
        }

        [Key]
        public long ID_TampOrder { get; set; }

        public long T_User_Id { get; set; }

        public long T_Address_Id { get; set; }

        [Required]
        [StringLength(50)]
        public string OrderStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string SendStatus { get; set; }

        [Required]
        [StringLength(50)]
        public string PaymentStatus { get; set; }

        public bool IsActive { get; set; }

        public long T_Order_Id { get; set; }

        public virtual T_Address T_Address { get; set; }

        public virtual T_Order T_Order { get; set; }

        public virtual T_User T_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampShoppingBasket> T_TampShoppingBasket { get; set; }
    }
}
