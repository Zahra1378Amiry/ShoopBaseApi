using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class ProductUpdateDto
    {
        [Key]
        public long ID_Product { get; set; }

        [Required(ErrorMessage = " نام محصول را وارد کنید ")]
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
    }
}
