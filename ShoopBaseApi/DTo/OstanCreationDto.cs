using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class OstanCreationDto
    {
        [Key]
        public int ID_Ostan { get; set; }

        [Required(ErrorMessage = " نام استان  را وارد کنید ")]
        [StringLength(200)]
        public string NameOstan { get; set; }
    }
}
