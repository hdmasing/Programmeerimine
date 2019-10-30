using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using tunnitoo3.Models;

namespace tunnitoo3
{
    public class Program
    {
      
        
        static void Main(string[] args)
        {
        List<double> prices  = new List<double>();
            List<Food> groceries = new List<Food>
            {
                new Food("apple", 1.7),
                new Food("bread", 2),
                new Food("cheese", 3),
                new Food("banana", 2)
            };
            ShoppingCart newCart = new ShoppingCart(0);
            
            beginning:
            askagain: Console.WriteLine("Millise toidu soovid korvi lisada?");
            string userinput = Console.ReadLine();
            Food chosenFood = groceries.FirstOrDefault(x => x.Name == userinput);
            newCart.Items.Add(chosenFood);
            int a;
            if (chosenFood == null)
            {
                Console.WriteLine("Toodet pole nimekirjas, sisesta teine toode.");
                goto askagain;//suunab tagasi ,rida 34
            }
            else
            {
                Console.WriteLine("Kui suurt kogust soovite?");
                
                question: string amount = Console.ReadLine();
                a = 0;
                bool success = int.TryParse(amount, out a);
                if (!success)
                {
                    Console.WriteLine("Peab olema täisarv, sisesta uuesti");

                    goto question; //suunab reale 43;

                }

            }
            Console.WriteLine("Kas te tahate midagi veel osta? Vajuta 1, kui soovid ja 0 kui ei soovi");
            repeatthisquestion: string number = Console.ReadLine();
            int abi = 2;
            bool tõene = int.TryParse(number, out abi);
            if (!tõene)
            {
                Console.WriteLine("Sisesta täisarv");
                goto repeatthisquestion;//suunab tagasi reale 54;
            }

            if (abi == 1)
            {
                double sum = chosenFood.CalculateSum(chosenFood, a);
                prices.Add(sum);
                Console.WriteLine("Toote maksumus on " + sum + "€");
                goto beginning;//tagasi reale 33

            }
            else if (abi == 0)
            {
                double sum = chosenFood.CalculateSum(chosenFood, a);
                prices.Add(sum);
                Console.WriteLine("Toote maksumus on " + sum + "€");

            }
            else
            {
                Console.WriteLine("Sisesta kas 1-jah või 0-ei");
                goto repeatthisquestion;//suunab reale 54
            }


            using (var db = new ShopDbContext())
            {
                db.ShoppingCarts.Add(newCart);
                db.SaveChanges();

                var carts = db.ShoppingCarts.Include("items").OrderByDescending(x=>x.DateCreated).ToList();
                var foods = db.Foods;
                foreach (var VARIABLE in carts)
                {
                    Console.WriteLine(Convert.ToString(VARIABLE.DateCreated));
                    
                    foreach (var food in foods)
                    {
                        Console.WriteLine(" toode " + food.Name + " maksumus " + food.Price);
                        
                    }
                    
                }
                var lastcartadded = db.ShoppingCarts.Include("items").OrderByDescending(x => x.DateCreated).ToList().First();
                Console.WriteLine(lastcartadded.DateCreated);

                var cartswithitems = db.ShoppingCarts;
                var cartswithoutitems = db.ShoppingCarts.Include("Items");

                var carts5 = carts.Where(x => x.Sum > 5).ToList();
                foreach (var cart in carts5)
                {
                    Console.WriteLine(cart.DateCreated);
                   
                }

                var cartwithmorethan1 = cartswithitems.Where(x => x.Items.Count() > 1).ToList();
                foreach (var cart in cartwithmorethan1)
                {
                    Console.WriteLine(cart.DateCreated);
                    Console.WriteLine(cart.Items.Count());
                    
                }

                var cartwithmorethan1query = from cart in cartswithitems where cart.Items.Count() > 1 select cart;
                foreach (var cart in cartwithmorethan1query)
                {
                    Console.WriteLine(cart.DateCreated);
                    Console.WriteLine(cart.Items.Count());
                    
                }

                cartswithitems.Where(x => x.Items.Any(y => y.Name == "banana"));

                var count = carts.Count();

                var cartmaxsum = cartswithitems.OrderByDescending(x => x.Sum).ToList().FirstOrDefault();
            }

            
        }
    }
}
