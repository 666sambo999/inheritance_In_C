//#define WRITE_TO_FILE
#define READ_FRON_FILE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File
{
    internal class Program
    {
        static void Main(string[] args)
        {
#if WRITE_TO_FILE

            string currentDirectory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine(currentDirectory);
            Console.WriteLine(Directory.GetCurrentDirectory());
            //StreamWriter sw = new StreamWriter(filename); 
            StreamWriter sw = new StreamWriter(filename,true); // добавление в конец ФАЙЛА
            sw.WriteLine("Hello BOB");
            sw.Close();
            Console.WriteLine(currentDirectory);
            Console.WriteLine(filename);
            string cmd = currentDirectory + "\\" + filename;
            Console.WriteLine(cmd);
            System.Diagnostics.Process.Start("notepad", cmd); 

#endif


#if READ_FRON_FILE
            
            string currentDirectory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine(currentDirectory);
            StreamReader sr = new StreamReader(filename); 
            for (int i=1; !sr.EndOfStream; i++)
            {
                string buffer = sr.ReadLine();
                Console.WriteLine(i + " " + buffer);
            }


#endif



        }
    }
}
