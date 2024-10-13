using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Ostan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Ostan()
        {
            T_Address = new HashSet<T_Address>();
            T_City = new HashSet<T_City>();
        }

        [Key]
        public int ID_Ostan { get; set; }

        [Required]
        [StringLength(200)]
        public string NameOstan { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Address> T_Address { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_City> T_City { get; set; }
    }
}
