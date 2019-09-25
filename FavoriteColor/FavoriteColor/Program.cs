using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FavoriteColor
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            List<Person> people = new List<Person>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\opilane\Desktop\WriteText.txt");
            System.Console.WriteLine("Contents of WriteLines.txt = ");
            foreach (string line in lines)
            {
                var names = line.Split(' ');
                Person person = new Person(names[0], names[1]);
                people.Add(person);
                Console.WriteLine("\t" + line);
            }
            Console.WriteLine("Sisesta oma perekonnanimi");
            question:
            string lastname = Console.ReadLine();
            Person someone = people.FirstOrDefault(x=>x.LastName==lastname);
            if (someone == null)
            {
                Console.WriteLine("Inimest ei leitud, sisesta uuesti");
                goto question;
            }
            Console.WriteLine("Tere, {0}! Mis on teie lemmik värv?", someone.FirstName);
            var answer = Console.ReadLine();
            Enum.TryParse(answer, true, out Person.Color favoriteColor);
            someone.FavoriteColor = favoriteColor;
            using (StreamWriter file = new StreamWriter("WriteText.txt"))
            {
                file.WriteLine($"{someone.FirstName} {someone.LastName} Lemmikvärv: {someone.FavoriteColor}");
            }

            
        }
    }
}
