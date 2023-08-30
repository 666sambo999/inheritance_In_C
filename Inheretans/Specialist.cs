using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Specialist: Graduate
    {
        // sealed - запред наследовать и переопределять дочерним классам (запечатанный)
        public int Grade { get; set; }

        public Specialist
            (string lastname, string firstname, int age,
                string speciality, string group, double rating, double attendance,
                string subject, int grade) : base (lastname, firstname, age, speciality, group, rating, attendance, subject) 
        {
            Grade = grade;
        }
        public override string ToString()
        {
            return base.ToString()+"," + $" {Grade}";
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine("Grade:\t" + Grade);
        }

    }
}
