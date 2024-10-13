using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_City()
        {
            T_Address = new HashSet<T_Address>();
        }

        [Key]
        public int ID_City { get; set; }

        [Required]
        [StringLength(250)]
        public string CityName { get; set; }

        public int T_Ostan_Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Address> T_Address { get; set; }

        public virtual T_Ostan T_Ostan { get; set; }
    }
}
