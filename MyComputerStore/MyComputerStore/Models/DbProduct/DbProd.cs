namespace MyComputerStore.Models.DbProduct
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DbProd : DbContext
    {
        public DbProd()
            : base("name=DbProd")
        {
        }

        public virtual DbSet<Components> Components { get; set; }
        public virtual DbSet<Configuration> configuration { get; set; }
        public virtual DbSet<Manufacturers> Manufacturers { get; set; }
        public virtual DbSet<OrderComponents> OrderComponents { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<TypesOfComponents> TypesOfComponents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Components>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Components>()
                .HasMany(e => e.Configuration)
                .WithMany(e => e.Components)
                .Map(m => m.ToTable("ConfigurationComponents").MapLeftKey("IdComponent").MapRightKey("IdConfiguration"));

            modelBuilder.Entity<Configuration>()
                .Property(e => e.PriceConfiguration)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Configuration>()
                .HasMany(e => e.OrderComponents)
                .WithRequired(e => e.Configuration)
                .HasForeignKey(e => e.IdComponent);

            modelBuilder.Entity<Orders>()
                .Property(e => e.money)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .HasOptional(e => e.OrderComponents)
                .WithRequired(e => e.Orders)
                .WillCascadeOnDelete();
        }
    }
}
