using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_SearchHistory
    {
        [Key]
        public long ID_Search { get; set; }

        [StringLength(500)]
        public string SearchQuery { get; set; }

        public long? T_User_Id { get; set; }

        public DateTime SearchDate { get; set; }

        public int? SearchCount { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
