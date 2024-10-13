using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class CityUpdateDto
    {
        [Key]
        public int ID_City { get; set; }

        [Required(ErrorMessage = " نام شهر را وارد کنید ")]
        [StringLength(250)]
        public string CityName { get; set; }

        public int T_Ostan_Id { get; set; }
    }
}
