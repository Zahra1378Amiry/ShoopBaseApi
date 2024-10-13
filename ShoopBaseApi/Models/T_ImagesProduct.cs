using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_ImagesProduct
    {
        [Key]
        public long ID_Images { get; set; }

        [Required]
        [StringLength(50)]
        public string Url { get; set; }

        public long T_Product_Id { get; set; }

        public virtual T_Product T_Product { get; set; }
    }
}
