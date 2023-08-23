using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheretans
{
    internal class Program
    {
        const string delimiter = "\n======================================\n";
        static void Main(string[] args)
        {
            #region Inheritance
            //Human human = new Human("Montana", "Jone", 30);
            //Console.WriteLine(human);

            //Student pinkman = new Student ("Pinkman","Jessie",25,"Chemestry", "SS_200", 80, 90);
            //Console.WriteLine(pinkman);

            //Teacher sport = new Teacher("Caesar", "Gay", 50, "Sportman", 20);
            //Console.WriteLine(sport);

            //Graduate hank = new Graduate("Puchkin", "Alex", 23, "Criminalist", "WW20", 70, 99, " how much is the fish");
            //Console.WriteLine(hank); 
            #endregion
            
            
            // добавление 
            Student tommi = new Student("Stalone", "Silver", 33, "Theft", "Vice", 80, 80);
            Specialist billy = new Specialist("Balboa", "Rooky", 24, "Box", "Vice", 80, 80, "Happy", 12);
            Teacher diaz = new Teacher("Roma", "Pupkin", 45, "Matimatic", 12);
            
            // полиморфизм 
            Human [] group = new Human[]
            {
                new Student("Pinkman", "Jessie", 25, "Chemestry", "SS_200", 80, 90),
                new Teacher("Caesar", "Gay", 50, "Sportman", 20),
                new Graduate("Puchkin", "Alex", 23, "Criminalist", "WW20", 70, 99, " how much is the fish"),
                tommi,diaz,billy
            };
            for (int i =0; i<group.Length;i++)
            {
                //Console.WriteLine(group[i]);
                group[i].Print();
                Console.WriteLine(delimiter);
            }



        }
    }
}
