using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Human
    {
        string LastName { get; set; }
        string FirstName { get; set; }
        int Age { set; get; }
        public Human(string lastname, string firstname, int age)
        {
            LastName = lastname;
            FirstName = firstname;
            Age = age;
        }
        public override string ToString()
        {
            return $"{LastName} {FirstName} {Age} лет.";
        }




    }
}
