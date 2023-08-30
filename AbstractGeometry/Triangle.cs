using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    abstract class Triangle: Shapes
    {
        protected Triangle(int start_x, int start_y, int line_widht, Color color):base (start_x, start_y, line_widht, color){}

        public abstract double GetHeight(); // у всех треугольник есть высота 
        public override void Info(PaintEventArgs e)
        {
            Console.WriteLine($"Высота треугольтника: {GetHeight()}");
            base.Info(e);
        }

    }
    

}
