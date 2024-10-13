using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Ganoon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Ganoon()
        {
            T_LowOk = new HashSet<T_LowOk>();
        }

        [Key]
        public long ID_Ganoon { get; set; }

        [Required]
        [StringLength(150)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime CreatedAt { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_LowOk> T_LowOk { get; set; }
    }
}
