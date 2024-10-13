using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class ImagesProductUpdateDto
    {
        [Key]
        public long ID_Images { get; set; }

        [Required(ErrorMessage = " Url را وارد کنید ")]
        [StringLength(50)]
        public string Url { get; set; }

        public long T_Product_Id { get; set; }

        public virtual T_Product T_Product { get; set; }
    }
}
