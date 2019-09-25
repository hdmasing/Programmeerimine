using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Program p = new Program();
            String firstname = p.EesnimeSisestus();
            String lastname = p.PerenimeSisestus();
            
            String code = p.Generatecode();
            Console.WriteLine("Enter if student is learning 1 for yes, 0 for no");
            bool answer = p.Yesorno();
            Student student = new Student(firstname, lastname, code, answer);
            Console.WriteLine("Create a group?");
            answer = p.Yesorno();
            if (answer == true)
            {
                Console.WriteLine("Enter a group name.");
                string groupname = Console.ReadLine();
                Console.WriteLine("Add last student to this group?");
                answer = p.Yesorno();
                if (answer == true)
                {
                  Group group = new Group(groupname);
                  group.AddToGroup(student);
                    
                }

                
            }
            Console.WriteLine("");

        }



        private bool Yesorno()
        {
            repeatthisquestion:
            string number = Console.ReadLine();
            int abi = 2;
            bool tõene = int.TryParse(number, out abi);
            if (!tõene)
            {
                Console.WriteLine("Enter a integer");
                goto repeatthisquestion;
            }

            if (abi == 1)
            {
                goto beginning;
            }
            else if (abi == 0)
            {

                goto beginning;

            }
            else
            {
                Console.WriteLine("Please enter 1 for yes, 0 for no");
                goto repeatthisquestion;
            }
            beginning:
            return tõene;
        }


    private string EesnimeSisestus()
    {
    Console.WriteLine("Enter firstname");
    string firstname;
    firstname = Console.ReadLine();
    return firstname;
    }
    private string PerenimeSisestus()
    {
        Console.WriteLine("Enter lastname");
            string lastname;
    lastname = Console.ReadLine();
    return lastname;
    }



    private string Generatecode()
    {
        
        Random generator = new Random();
        string r = generator.Next(0, 999999).ToString("D6");
            return r;
    }
    
    }
}
