// Наследование 
//#define WRITE_TO_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Runtime.Remoting.Messaging;

namespace Academy
{
    internal class Program
    {
        const string delimiter = "\n=================================================\n";
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

#if WRITE_TO_FILE

            // добавление 
            Student tommi = new Student("Stalone", "Silver", 33, "Theft", "Vice", 80, 80);
            Specialist billy = new Specialist("Balboa", "Rooky", 24, "Box", "Vice", 80, 80, "Happy", 12);
            Teacher diaz = new Teacher("Roma", "Pupkin", 45, "Matimatic", 12);

            // полиморфизм 
            Human[] group = new Human[]
            {
                new Student("Pinkman", "Jessie", 25, "Chemestry", "SS_200", 80, 90),
                new Teacher("Caesar", "Gay", 50, "Sportman", 20),
                new Graduate("Puchkin", "Alex", 23, "Criminalist", "WW20", 70, 99, " how much is the fish"),
                tommi,diaz,billy
            };
            string currentDirectory = Directory.GetCurrentDirectory();
            string filename = "group.txt";
            StreamWriter streamWriter = new StreamWriter(filename);
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]+ ";");
                streamWriter.WriteLine(group[i]+";");
                //group[i].Print();
                Console.WriteLine(delimiter);
            }
            streamWriter.Close();
            string cmd = currentDirectory + "\\" + filename;
            System.Diagnostics.Process.Start("group.txt", cmd);
            streamWriter.Close();

#endif
            Load("group.txt");
        }
        static Human[] Load(string filename)
        {
            Human[] group = null;
            List<Human> l_group =new List<Human> { };
            StreamReader stream = new StreamReader(filename);
            while(!stream.EndOfStream)
            {
                string buffer = stream.ReadLine();
                // разбить строку можно методом String.Split
                string[] values = buffer.Split(new char[] {':',',',';'});
                //Console.WriteLine( buffer);
                //foreach(string i in values)Console.Write( i+"\t");
                //Console.WriteLine();
                //Console.WriteLine( delimiter);
                l_group.Add(HumanFactory(values[0]));
                //l_group.Last().GetType();
                l_group.Last();
            }
            stream.Close();
            return group;
        }
        static Human HumanFactory(string type)
        {
            Human obj = null;
            if (type == typeof(Academy.Student).ToString()) obj = new Student("", "", 0, "", "", 0, 0);
            if (type == typeof(Academy.Teacher).ToString()) obj = new Teacher("", "", 0, "", 0);
            if (type == typeof(Academy.Graduate).ToString()) obj = new Graduate("", "", 0, "", "", 0, 0,"");
            if (type == typeof(Academy.Specialist).ToString()) obj = new Specialist("", "", 0, "", "", 0, 0,"",0);
            return obj;
        }
        static Human InitHuman(Human obj, string[] values)
        {
            if (obj.GetType() == typeof(Academy.Student))
            {

            }
            return obj;
        }
       
    }
}
