namespace MyComputerStore.Models.DbAccount
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Accounts
    {
        [Key]
        public int idAccount { get; set; }

        [Required]
        [StringLength(50)]
        public string login { get; set; }

        [Required]
        [StringLength(50)]
        public string password { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateRegistration { get; set; }

        public int idStatus { get; set; }

        public virtual UserStatuses UserStatuses { get; set; }
    }
}
