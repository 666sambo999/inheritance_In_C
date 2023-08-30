using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Inheretans
{
    internal class Teacher: Human
    {
        public string Speciality { get; set; }  
        public int Experience { get; set; }

        public Teacher (string lastname, string firstname, int age, 
            string speciality, int experience): base(lastname, firstname,age)
        {
            Speciality = speciality;
            Experience = experience;
        }
        public override string ToString()
        {
            return base.ToString() +",\t\t" + $" {Speciality}, {Experience} лет. ";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Speciality:\t" + Speciality);
            Console.WriteLine("Experiens:\t" + Experience);
        }
    }
}
