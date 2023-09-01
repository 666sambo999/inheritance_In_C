// Наследование 
//#define WRITE_TO_FILE
//#define File
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


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
            Human[] group = Load("group.txt");
            for (int i = 0; i < group.Length; i++)
            {
                Console.WriteLine(group[i]);
            }
            //Console.WriteLine(typeof(Academy.Student).ToString());
        }
        static Human[] Load(string filename)
        {
            Human[] group = null;
            List<Human> l_group =new List<Human> ();
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
                //l_group.Last();
                //InitHuman(l_group.Last(), values);
                l_group.Last().Init(values);    
            }
            stream.Close();
            return l_group.ToArray();
        }
        static Human HumanFactory(string type)
        {
            Human human = null;
            if (type == typeof(Academy.Student).ToString()) human = new Student("", "", 0, "", "", 0, 0);
            if (type == typeof(Academy.Teacher).ToString()) human = new Teacher("", "", 0, "", 0);
            if (type == typeof(Academy.Graduate).ToString()) human = new Graduate("", "", 0, "", "", 0, 0,"");
            if (type == typeof(Academy.Specialist).ToString()) human = new Specialist("", "", 0, "", "", 0, 0,"",0);
            return human;
        }
#if File
        static Human InitHuman(Human obj, string[] values)
        {
            if (obj.GetType() == typeof(Academy.Student))
            {
                ((Student)obj).LastName = values[1].TrimStart().TrimEnd();
                ((Student)obj).FirstName = values[2].TrimStart().TrimEnd();
                string[] age = values[3].Split(' ');
                //foreach (string i in age) Console.Write(i + " "); Console.WriteLine();
                ((Student)obj).Age = Convert.ToInt32(age[1]);
                //((Student)obj).Age = Convert.ToInt32(values[3].Split(' ')[1]);
                ((Student)obj).Speciality = values[4].TrimStart().TrimEnd();
                ((Student)obj).Group = values[5].TrimStart().TrimEnd();
                ((Student)obj).Rating = Convert.ToDouble(values[6]);
                ((Student)obj).Attendance = Convert.ToDouble(values[7]);
            }
            if (obj.GetType() == typeof(Academy.Graduate))
            {
                ((Graduate)obj).LastName = values[1].TrimStart().TrimEnd();
                ((Graduate)obj).FirstName = values[2].TrimStart().TrimEnd();
                string[] age = values[3].Split(' ');
                ((Graduate)obj).Age = Convert.ToInt32(age[1]);
                //((Graduate)obj).Age = Convert.ToInt32(values[3].Split(' ')[1]);
                ((Graduate)obj).Speciality = values[4].TrimStart().TrimEnd();
                ((Graduate)obj).Group = values[5].TrimStart().TrimEnd();
                ((Graduate)obj).Rating = Convert.ToDouble(values[6]);
                ((Graduate)obj).Attendance = Convert.ToDouble(values[7]);
                ((Graduate)obj).Subject = values[8].TrimStart().TrimEnd();
            }
            if (obj.GetType() == typeof(Academy.Specialist))
            {
                ((Specialist)obj).LastName = values[1].TrimStart().TrimEnd();
                ((Specialist)obj).FirstName = values[2].TrimStart().TrimEnd();
                ((Specialist)obj).Age = Convert.ToInt32(values[3].Split(' ')[1]);
                ((Specialist)obj).Speciality = values[4].TrimStart().TrimEnd();
                ((Specialist)obj).Group = values[5].TrimStart().TrimEnd();
                ((Specialist)obj).Rating = Convert.ToDouble(values[6]);
                ((Specialist)obj).Attendance = Convert.ToDouble(values[7]);
                ((Specialist)obj).Subject = values[8].TrimStart().TrimEnd();
                ((Specialist)obj).Grade = Convert.ToInt32(values[9]);
            }
            if (obj.GetType() == typeof(Academy.Teacher))
            {
                ((Teacher)obj).LastName = values[1].TrimStart().TrimEnd();
                ((Teacher)obj).FirstName = values[2].TrimStart().TrimEnd();
                ((Teacher)obj).Age = Convert.ToInt32(values[3].Split(' ')[1]);
                ((Teacher)obj).Speciality = values[4].TrimStart().TrimEnd(); ;
                ((Teacher)obj).Experience = Convert.ToInt32(values[5].Split(' ')[1]);
            }
            return obj;
        } 
#endif
    }
       
    
}
