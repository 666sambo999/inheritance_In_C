using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Teacher: Human
    {
        public string Speciality { get; set; }  
        public int Experiens { get; set; }

        public Teacher (string lastname, string firstname, int age, 
            string speciality, int experiens): base(lastname, firstname,age)
        {
            Speciality = speciality;
            Experiens = experiens;
        }
        public override string ToString()
        {
            return base.ToString() + $" {Speciality} {Experiens} лет. ";
        }
    }
}
