using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    }
}
