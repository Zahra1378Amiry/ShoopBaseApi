using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoopBaseApi.Models
{
    public class T_TampShoppingBasket
    {
        [Key]
        public long ID_TampShoppingBasket { get; set; }

        public long T_User_Id { get; set; }

        public long T_Product_Id { get; set; }

        public int Quantity { get; set; }

        public decimal UnitPrice { get; set; }

        public DateTime CreatedAt { get; set; }

        [Required]
        [StringLength(10)]
        public string IsActive { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal? TotalPrice { get; set; }

        public long T_ShoppingBasket_Id { get; set; }

        public long? T_TampOrder_Id { get; set; }

        public virtual T_Product T_Product { get; set; }

        public virtual T_ShoppingBasket T_ShoppingBasket { get; set; }

        public virtual T_TampOrder T_TampOrder { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
