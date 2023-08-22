using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Graduate : Student
    {
        public string Subject { get; set; }
        public Graduate
            (string lastname, string firstname, int age,
                string speciality, string group, double rating, double attendance,
                string subject) : base(lastname, firstname, age, speciality, group, rating, attendance)
        {
            Subject = subject;
        }
        public override string ToString()
        {
            return base.ToString() + " " + Subject;
        }
    }
}
