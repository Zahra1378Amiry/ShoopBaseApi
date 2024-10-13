using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Category()
        {
            T_Product = new HashSet<T_Product>();
        }

        [Key]
        public int ID_Category { get; set; }

        [Required]
        [StringLength(150)]
        public string NameCategory { get; set; }

        public DateTime? CreatedAt { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Product> T_Product { get; set; }
    }
}
