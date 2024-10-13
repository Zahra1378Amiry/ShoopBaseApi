using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Offer
    {
        [Key]
        public long ID_Offer { get; set; }

        [StringLength(200)]
        public string Title { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        public decimal? PriceOffer { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool IsActive { get; set; }

        public long ID_Prodect_Id { get; set; }

        public virtual T_Product T_Product { get; set; }
    }
}
