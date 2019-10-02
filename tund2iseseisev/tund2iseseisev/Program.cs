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
                     
            Console.WriteLine("Vali kujund, mida soovid sisestada, 1 on ristkülik ja 0 on ruut");
            bool answer = p.Yesorno();
            if (answer == true)
            {
                 Kujund.Ristkülik.Ruut ruut = new Kujund.Ristkülik.Ruut();   
                 Console.Write("Sisesta ruudu külg A");
                 int c = ruut.A;
                 int d = c;
                 Console.WriteLine("Ruudu pindala on "+ruut.Pindala(c, d));
            }else if (answer == false)
            {
                Kujund.Ristkülik ristkülik= new Kujund.Ristkülik();
                Console.WriteLine("Sisesta ristküliku külg A ja seejärel B");
                Console.Write("Ristküliku külg A: "); int a = ristkülik.A;
                Console.Write("Ristküliku külg B: "); int b = ristkülik.B;
                Console.WriteLine("Ristküliku pindala on " + ristkülik.Pindala(a,b));
            }

        }
        private bool Yesorno()
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
                    return false;
                   
                }
                else if (abi == 0)
                {

                    goto beginning;

                }
                else
                {
                    Console.WriteLine("Palun sisesta 1 või 0");
                    goto repeatthisquestion;
                }
                beginning:
                return tõene;
            }
    }
}
