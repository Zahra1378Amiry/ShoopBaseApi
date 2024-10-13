using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoopBaseApi.Models
{
    public class T_ShoppingBasket
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_ShoppingBasket()
        {
            T_TampShoppingBasket = new HashSet<T_TampShoppingBasket>();
        }

        [Key]
        public long ID_ItemShopping { get; set; }

        public long T_User_Id { get; set; }

        public long T_Product_Id { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TotalPrice { get; set; }

        public virtual T_Product T_Product { get; set; }

        public virtual T_User T_User { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampShoppingBasket> T_TampShoppingBasket { get; set; }
    }
}
