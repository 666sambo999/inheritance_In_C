using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
    internal class Human
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { set; get; }
        public Human(string lastname, string firstname, int age)
        {
            LastName = lastname;
            FirstName = firstname;
            Age = age;
        }
        public virtual void Init (string[] values)
        {
            LastName = values[1].TrimStart().TrimEnd();
            FirstName = values[2].TrimStart().TrimEnd();
            Age = Convert.ToInt32(values[3].Split(' ')[1]);
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
