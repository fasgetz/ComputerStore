namespace MyComputerStore.Models.DbProduct
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderComponents
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int IdOrder { get; set; }

        public int IdComponent { get; set; }

        public virtual Components Components { get; set; }

        public virtual Configuration Configuration { get; set; }

        public virtual Orders Orders { get; set; }
    }
}
