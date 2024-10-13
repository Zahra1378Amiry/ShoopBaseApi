using System.ComponentModel.DataAnnotations;

namespace ShoopBaseApi.Models
{
    public class T_Address
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_Address()
        {
            T_Order = new HashSet<T_Order>();
            T_TampOrder = new HashSet<T_TampOrder>();
        }

        [Key]
        public long ID_Address { get; set; }

        public long T_User_Id { get; set; }

        public int T_Ostan_Id { get; set; }

        public int T_City_Id { get; set; }

        [Required]
        [StringLength(450)]
        public string Adrress { get; set; }

        [StringLength(15)]
        public string CodePost { get; set; }

        [Required]
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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_Order> T_Order { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_TampOrder> T_TampOrder { get; set; }
    }
}
