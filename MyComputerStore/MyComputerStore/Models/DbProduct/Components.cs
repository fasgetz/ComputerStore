namespace MyComputerStore.Models.DbProduct
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Components
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Components()
        {
            OrderComponents = new HashSet<OrderComponents>();
            Configuration = new HashSet<Configuration>();            
        }

        [Key]
        public int IdComponent { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public int IdType { get; set; }

        public int IdManufacturer { get; set; }

        [Column(TypeName = "money")]
        public decimal Price { get; set; }

        public int AvailabilityCount { get; set; }

        [StringLength(100)]
        public string Properties { get; set; }

        public virtual Manufacturers Manufacturers { get; set; }

        public virtual TypesOfComponents TypesOfComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderComponents> OrderComponents { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Configuration> Configuration { get; set; }
    }
}
