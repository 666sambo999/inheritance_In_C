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
        static readonly string delimetr = "\n=====================================\n";
        static void Main(string[] args)
        {
            IntPtr hwnd = GetConsoleWindow();
            Graphics graphics = Graphics.FromHwnd(hwnd);
            System.Drawing.Rectangle window_rect = new System.Drawing.Rectangle
                (
                    Console.WindowLeft, Console.WindowTop, 
                    Console.WindowWidth, Console.WindowHeight);
           
            PaintEventArgs e = new PaintEventArgs(graphics,window_rect);

            Regtangle regtangle = new Regtangle(150,130,800,700,4,Color.DarkRed);
            //Console.WriteLine($"Сторона 'A': {regtangle.SideA} ");
            //Console.WriteLine($"Сторона 'B': {regtangle.SideB} ");
            //Console.WriteLine($" Площадь треугольника: {regtangle.GetArea()}");
            //Console.WriteLine($" периметр треугольника: {regtangle.GetPerimetr()}");
            //regtangle.Draw(e);
            regtangle.info(e);
            Console.WriteLine(delimetr);
            Square square = new Square(420, 500, 355, 3, Color.AntiqueWhite);
            square.info(e);

            Circle circle = new Circle(60, 300, 200, 3, Color.Chocolate);
            circle.info(e);

        }
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetConsoleWindow();
        [DllImport("kernel32.dll")]
        public static extern IntPtr GetDC(IntPtr hwnd);



    }
}
