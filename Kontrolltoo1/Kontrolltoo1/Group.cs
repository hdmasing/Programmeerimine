using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo1
{
    public class Group
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public string Groupname { get; set; }
        public Student Student { get; set; }
        

        public Group(string groupname)
        {
            //Student = student;
            Groupname = groupname;
        }

        public void AddToGroup(Student student)
        {
            
            Students.Add(student);
            foreach (Student s in Students)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.PersonalCode);
            }
        }

    }
}
