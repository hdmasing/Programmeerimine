using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tunnitoo3.Models;

namespace tunnitoo3
{
    public class ShopDbContext : DbContext
    {
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Food> Foods { get; set; }

        public ShopDbContext()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ShopDbContext, ConsoleApp2.Migrations.Configuration>());
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ShoppingCart>()
                .HasMany(c=>c.Items)
                .WithRequired(c=>c.ShoppingCart)
                .WillCascadeOnDelete();

        }
    }
}
