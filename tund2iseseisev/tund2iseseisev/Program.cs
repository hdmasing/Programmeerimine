using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund2iseseisev
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
                     
            Console.WriteLine("Vali kujund, mida soovid sisestada, 2 on ring, 1 on ristkülik ja 0 on ruut");
            int answer = p.Yesorno();
            if (answer == 1)
            {
                 Shape.Rectangle.Square square = new Shape.Rectangle.Square();   
                 Console.Write("Sisesta ruudu külg A");
                 int c = square.A;
                 int d = c;
                 Console.WriteLine("Ruudu pindala on "+square.Pindala(c, d));
                 Console.WriteLine("Ruudu ümbermõõt on " + square.Perimeter(c, d));
            }
            else if (answer == 0)
            {
                Shape.Rectangle rectangle= new Shape.Rectangle();
                Console.WriteLine("Sisesta ristküliku külg A ja seejärel B");
                Console.Write("Ristküliku külg A: "); int a = rectangle.A;
                Console.Write("Ristküliku külg B: "); int b = rectangle.B;
                Console.WriteLine("Ristküliku pindala on " + rectangle.Pindala(a,b));
                Console.WriteLine("Ristküliku ümbermõõt on " + rectangle.Perimeter(a,b));
            }
            else if(answer==2)
            {
                Shape.Circle circle = new Shape.Circle();
                Console.Write("Sisesta ringi raadius: "); int a = circle.A;
                double b = 3.14;
                Console.WriteLine("Ringi ümbermõõt on " + circle.CirclePerimeter(a,b));
                Console.WriteLine("Ringi pindala on " + circle.CircleSize(a,b));
            }

        }
        private int Yesorno()
            {
                repeatthisquestion:
                string number = Console.ReadLine();
                int abi = 2;
                bool tõene = int.TryParse(number, out abi);
                if (!tõene)
                {
                    Console.WriteLine("Sisesta 1 või 0");
                    
                    goto repeatthisquestion;
                }

                if (abi == 1)
                {
                    return 1;
                   
                }
                else if (abi == 0)
                {

                    return 0;

                }
                else if(abi == 2)
                {
                    return 2;
                }
                else
                {
                    Console.WriteLine("Palun sisesta 1 või 0");
                    goto repeatthisquestion;
                }
                
                
            }
    }
}
