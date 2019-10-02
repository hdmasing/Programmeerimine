using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace tund2iseseisev
{
    public class Kujund
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }
        public virtual int Umbermoot { get; set; }
        public class Ristkülik : Kujund
        {
            public override int A
            {
                get { return Convert.ToInt32(Console.ReadLine()); }
            }
            public override int B
            {
                get { return Convert.ToInt32(Console.ReadLine());}
            }
            public class Ruut : Kujund
            {
                public override int A
                {
                    get { return Convert.ToInt32(Console.ReadLine()); }
                }
                public override int B
                {
                    get { return Convert.ToInt32(Console.ReadLine()); }
                }
            }  
        }
            public int Pindala(int A, int B)
            {
                
                return A * B;
            }

            public int Perimeter(int A, int B)
            {
                return 2 * A + 2 * B;
            }
    }
}
