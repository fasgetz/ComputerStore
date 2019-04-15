namespace MyComputerStore.Models.DbAccount
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbAcc : DbContext
    {
        public DbAcc()
            : base("name=DbAcc")
        {
        }

        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<UserStatuses> UserStatuses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
