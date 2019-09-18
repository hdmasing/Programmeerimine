using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Proge1
{
    public class Client
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ShoppingCart ShoppingCart { get; set; }

        public Client(string firstname, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;

        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}
