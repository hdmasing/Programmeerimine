using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Kontrolltoo1
{
    public class Student
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PersonalCode { get; set; }
        public bool IsStudying { get; set; }
        public Status  PersonStatus{ get; set; }



        public Student(string firstname, string lastName, string personalcode, bool study)
        {
            FirstName = firstname;
            LastName = lastName;
            PersonalCode = personalcode;
            IsStudying = study;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

        public enum Status
        {
            Unknown,
            Studying,
            Graduated,
            Exmatriculated,
            OnAcademicLeave
        }


    }
}
