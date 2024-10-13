using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Product()
        {
            T_Feedback = new HashSet<T_Feedback>();
            T_ImagesProduct = new HashSet<T_ImagesProduct>();
            T_Offer = new HashSet<T_Offer>();
            T_ShoppingBasket = new HashSet<T_ShoppingBasket>();
            T_TampShoppingBasket = new HashSet<T_TampShoppingBasket>();
        }

        [Key]
        public long ID_Product { get; set; }

        [Required]
        [StringLength(200)]
        public string NameProduct { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public decimal? Price { get; set; }

        public int? C_Product { get; set; }

        public int? T_Category_Id { get; set; }

        public DateTime? CreatedAt { get; set; }

        public bool? ISActive { get; set; }

        public virtual T_Category T_Category { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Feedback> T_Feedback { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ImagesProduct> T_ImagesProduct { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Offer> T_Offer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_ShoppingBasket> T_ShoppingBasket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampShoppingBasket> T_TampShoppingBasket { get; set; }
    }
}
