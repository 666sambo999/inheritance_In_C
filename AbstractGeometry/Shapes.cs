using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace AbstractGeometry // базовый класс
{
    abstract internal class Shapes
    {
        //public static readonly MIN_START_X
        int start_x;
        int start_y;
        int line_widht;
        public Color Color { get; set; }
        public int StartX
        {
            get { return start_x; }
            set
            {
                if (value < 10) value = 10;
                if (value > 700) value = 500;
                start_x = value;
            }
        }
        public int StartY
        {
            get { return start_y; }
            set
            {
                if (value < 10) value = 10;
                if (value > 500) value = 500;
                start_x = value;
            }
        }
        public int LineWht
        {
            get { return line_widht; }
            set
            {
                if (value < 1) value = 1;
                if (value > 32) value = 32;
                line_widht = value;
            }
        }
        public Shapes(int start_x, int start_y, int line_widht, Color color)
        {
            StartX = start_x;
            StartY = start_y;
            LineWht = line_widht;
            Color = color;
        }
        public abstract double GetArea();
        public abstract double GetPerimetr();
        public abstract void Draw(PaintEventArgs e);

        public virtual void Info(PaintEventArgs e) // метод 
        {
            Console.WriteLine($" Площадь фигуры: {this.GetArea()}");
            Console.WriteLine($" периметр фигуры: {this.GetPerimetr()}");
            this.Draw(e);
        }
    }
}
