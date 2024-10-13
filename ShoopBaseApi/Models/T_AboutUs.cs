using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_AboutUs
    {
        [Key]
        public long ID_AboutUs { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }

        public bool IsActive { get; set; }
    }
}
