using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class AddressCreationDto
    {
        [Key]
        public long ID_Address { get; set; }

        public long T_User_Id { get; set; }

        public int T_Ostan_Id { get; set; }

        public int T_City_Id { get; set; }

        [Required(ErrorMessage = " آدرس را وارد کنید ")]
        [StringLength(450)]
        public string Adrress { get; set; }

        [StringLength(15)]
        public string CodePost { get; set; }

        [Required(ErrorMessage = " موبایل را وارد کنید ")]
        [StringLength(15)]
        public string Mobile { get; set; }

        [StringLength(15)]
        public string Phone { get; set; }

        [StringLength(250)]
        public string AddressType { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        public virtual T_City T_City { get; set; }

        public virtual T_Ostan T_Ostan { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
