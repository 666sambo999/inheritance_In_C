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
            string currentDirectory = Directory.GetCurrentDirectory();
            string filename = "File.txt";
            Console.WriteLine(currentDirectory);
            Console.WriteLine(Directory.GetCurrentDirectory());
            StreamWriter sw = new StreamWriter("File.txt");
            sw.WriteLine("Hello");
            sw.Close();
            Console.WriteLine(currentDirectory);
            Console.WriteLine(filename);
            string cmd = currentDirectory + "\\" + filename;
            Console.WriteLine(cmd);
            System.Diagnostics.Process.Start("notepad",cmd);
            
        }
    }
}
