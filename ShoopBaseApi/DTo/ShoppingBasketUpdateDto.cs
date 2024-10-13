using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoopBaseApi.DTo
{
    public class ShoppingBasketUpdateDto
    {
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
    }
}
