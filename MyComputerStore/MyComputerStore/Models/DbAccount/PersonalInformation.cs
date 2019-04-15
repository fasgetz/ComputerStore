namespace MyComputerStore.Models.DbAccount
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonalInformation")]
    public partial class PersonalInformation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdAccount { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Family { get; set; }

        [StringLength(50)]
        public string Surname { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DateBirthday { get; set; }

        [StringLength(1)]
        public string Gender { get; set; }

        public virtual Accounts Accounts { get; set; }
    }
}
