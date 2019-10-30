using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using ShopDatabaseAdvanced.Models;

namespace ShopDatabaseAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
           /* List<Food> foods = new List<Food>
            {
                new Food("Apple", 3),
                new Food("Banana", 4),
                new Food("Mango", 2),
                new Food("Onion", 3),
                new Food("Milk", 1)

            };*/
            using (var db = new ADvancedShopDatabaseContext())
            {
               // db.Foods.AddRange(foods);
                //db.SaveChanges();


            ShoppingCart newCart= new ShoppingCart();
            db.ShoppingCarts.Add(newCart);
            ChooseFood(db, newCart);
            while (Console.ReadLine()== "yes")
            {
                ChooseFood(db, newCart);
            }

            db.SaveChanges();
            var shoppingCarts = db.ShoppingCarts.Include("Items");
            foreach (var cart in shoppingCarts)
            {
                Console.WriteLine(cart.DateCreated);
                foreach (var food in cart.Items)
                {
                    Console.WriteLine(food.Name);
                    Console.WriteLine(food.Price);
                }
            }
            }
         

        }

        public static void ChooseFood(ADvancedShopDatabaseContext db, ShoppingCart newCart)
        {
            Console.WriteLine("Mida ostad?");
            string foodName = Console.ReadLine();
            Food chosenFood = db.Foods.FirstOrDefault(x => x.Name == foodName);
            newCart.AddToCart(chosenFood);
            Console.WriteLine("Anything else? yes/no");
        }

        
    }
}
