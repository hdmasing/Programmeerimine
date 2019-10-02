using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tund2
{
    public class Animal
    {
        public virtual int legN;
        public abstract Talk()
        {

        }
        public class Mammal
        {
            public override int legN
            {
                get { return 4; }
            }
            public override Talk()
            {

            }

            public class Dog : Mammal
            {
                public override Talk()
                {
                    Console.WriteLine("Woof woof");
                    
                }
            }

            public class Cat : Mammal
            {
                public override Talk()
                {
                    Console.WriteLine("Meow");
                }
            }
        }

        public class Bird
        {
            public override Talk()
            {
                 Console.Write("Birds sing");
                 
            }
            public override int legN
            {
                get { return 2; }
            }
        }
    }
}
