using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Student: Human
    {
        public string Speciality { get; set; }
        public string Group { get; set; }
        public double Rating { get; set; } 
        public double Attendance { get; set; }  

        public Student
            (string lastname, string firstname, int age,
                string speciality, string group, double rating, double attendance):base(lastname,firstname,age)
        {
            Speciality = speciality;
            Group = group;
            Rating = rating;
            Attendance = attendance;
        }
        public override string ToString()
        {
            return base.ToString()+ $"{Speciality} {Group} {Rating} {Attendance}";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Speciality:\t"+ Speciality);
            Console.WriteLine("Group:\t\t"+ Group);
            Console.WriteLine("Rating:\t\t" + Rating);
            Console.WriteLine("Attendance:\t" + Attendance);
        }

    }
}
