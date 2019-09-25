using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteColor
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public ShoppingCart ShoppingCart { get; set; }

        public Color FavoriteColor { get; set; }

        public Person(string firstname, string lastName)
        {
            FirstName = firstname;
            LastName = lastName;

        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public enum Color
        {
            Unknown,
            Sinine,
            Must,
            Kollane,
            Punane,
            Lilla,
            Roheline,
            Valge
        }
    }
}
