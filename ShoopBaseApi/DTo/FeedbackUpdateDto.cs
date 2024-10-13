using ShoopBaseApi.Models;
using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.DTo
{
    public class FeedbackUpdateDto
    {
        [Key]
        public long ID_Feedback { get; set; }

        public long ID_UserSingup_Id { get; set; }

        public long ID_Product_Id { get; set; }

        [StringLength(100)]
        public string Title { get; set; }

        [StringLength(500)]
        public string CommentText { get; set; }

        public int? Rating { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        public virtual T_Product T_Product { get; set; }

        public virtual T_User T_User { get; set; }
    }
}
