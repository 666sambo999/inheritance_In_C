using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
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
            return $"{this.GetType()}: \t {LastName}, {FirstName}, {Age} лет.";
        }
        public virtual void Print()
        {
            Console.WriteLine(this.GetType());
            Console.WriteLine("Last name:\t " + LastName);
            Console.WriteLine("First name:\t " + FirstName);
            Console.WriteLine("Age:\t\t " + Age);
        }



    }
}
