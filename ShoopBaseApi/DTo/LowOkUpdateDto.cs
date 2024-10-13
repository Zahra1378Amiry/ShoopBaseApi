using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class LowOkUpdateDto
    {
        [Key]
        public long ID_LowOk { get; set; }

        public long T_User_Id { get; set; }

        public long T_Ganoon_Id { get; set; }

        public DateTime CreatedAt { get; set; }

        [StringLength(50)]
        public string IPUser { get; set; }

        public virtual T_Ganoon T_Ganoon { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
