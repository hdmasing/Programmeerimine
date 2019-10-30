using ShopDatabaseAdvanced.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDatabaseAdvanced
{
    public class ADvancedShopDatabaseContext :DbContext
    {

        public ADvancedShopDatabaseContext() : base("AdvacedShopingDatabase")
        {

        }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}
