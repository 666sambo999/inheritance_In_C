using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AbstractGeometry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop, 
                    Console.WindowWidth, Console.WindowHeight);
           
            PaintEventArgs e = new PaintEventArgs(graphics,window_rect);

            Regtangle regtangle = new Regtangle(50,40,600,600,3,Color.DarkRed);
            Console.WriteLine($"Сторона 'A': {regtangle.SideA} ");
            Console.WriteLine($"Сторона 'B': {regtangle.SideB} ");
            Console.WriteLine($" Площадь треугольника: {regtangle.GetArea()}");
            Console.WriteLine($" периметр треугольника: {regtangle.GetPerimetr()}");
            regtangle.Draw(e);

        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);



    }
}
