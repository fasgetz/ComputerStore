namespace MyComputerStore.Models.DbProduct
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Orders
    {
        [Key]
        public int IdOrder { get; set; }

        public DateTime DateOrder { get; set; }

        [Column(TypeName = "money")]
        public decimal money { get; set; }

        public bool? Status { get; set; }

        public virtual OrderComponents OrderComponents { get; set; }
    }
}
