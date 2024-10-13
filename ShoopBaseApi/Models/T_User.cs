using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_User()
        {
            T_Address = new HashSet<T_Address>();
            T_Feedback = new HashSet<T_Feedback>();
            T_LowOk = new HashSet<T_LowOk>();
            T_Order = new HashSet<T_Order>();
            T_Payment = new HashSet<T_Payment>();
            T_SearchHistory = new HashSet<T_SearchHistory>();
            T_SendEmail = new HashSet<T_SendEmail>();
            T_ShoppingBasket = new HashSet<T_ShoppingBasket>();
            T_TampOrder = new HashSet<T_TampOrder>();
            T_TampShoppingBasket = new HashSet<T_TampShoppingBasket>();
        }

        [Key]
        public long ID_User { get; set; }

        [Required]
        [StringLength(100)]
        public string FristName { get; set; }

        [Required]
        [StringLength(100)]
        public string LastName { get; set; }

        [Required]
        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(100)]
        public string Emile { get; set; }

        [StringLength(200)]
        public string Images { get; set; }

        public bool ISActive { get; set; }

        [Required]
        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(100)]
        public string Password { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Address> T_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Feedback> T_Feedback { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LowOk> T_LowOk { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Order> T_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Payment> T_Payment { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SearchHistory> T_SearchHistory { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_SendEmail> T_SendEmail { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ShoppingBasket> T_ShoppingBasket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampOrder> T_TampOrder { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampShoppingBasket> T_TampShoppingBasket { get; set; }
    }
}
