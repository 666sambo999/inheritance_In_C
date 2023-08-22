using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human("Montana", "Jone", 30);
            Console.WriteLine(human);

            Student pinkman = new Student ("Pinkman","Jessie",25,"Chemestry", "SS_200", 80, 90);
            Console.WriteLine(pinkman);

            Teacher sport = new Teacher("Caesar", "Gay", 50, "Sportman", 20);
            Console.WriteLine(sport);

            Graduate hank = new Graduate("Puchkin", "Alex", 23, "Criminalist", "WW20", 70, 99, " how much is the fish");
            Console.WriteLine(hank);
        }
    }
}
