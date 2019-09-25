using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Proge1
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Food> groceries = new List<Food>
            {
                new Food("banana", 1.2),
                new Food("potatoes", 1),
                new Food("apple", 3),
                new Food("icecream", 5)
            };

            Console.WriteLine("Sisesta eesnimi");
            string nimi = Console.ReadLine();
            Console.WriteLine("Sisesta perekonnanimi");
            string perenimi = Console.ReadLine();
            Client client = new Client(nimi, perenimi);
            Console.WriteLine("Head ostlemist " + client);
            client.ShoppingCart = new ShoppingCart();
            
            beginning: Console.WriteLine("Mida soovite osta?");
            askagain: string food = Console.ReadLine();
            Food chosenFood = groceries.FirstOrDefault(x => x.Name == food);
            if (chosenFood == null)
            {
                Console.WriteLine("Toodet pole nimekirjas, sisesta teine toode.");
                goto askagain;//suunab tagasi ,rida 34
            }else{
                Console.WriteLine("Kui suurt kogust soovite?");
               
                question: string amount = Console.ReadLine();
                int a=0;
                bool success = int.TryParse(amount, out a);
                if (!success)
                {
                    Console.WriteLine("Peab olema täisarv, sisesta uuesti");
                    goto question;//suunab reale 43;
                }
                client.ShoppingCart.AddToCart(chosenFood, a);
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
                goto beginning;//tagasi reale 33
            }else if (abi == 0)
            {
                double sum = client.ShoppingCart.CalculateSum();
                Console.WriteLine("Ostukorvi maksumus on " + sum +"€");

            }else
            {
                Console.WriteLine("Sisesta kas 1-jah või 0-ei");
                goto repeatthisquestion;//suunab reale 54
            }
            
        }
    }
}
