using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Circle: Shapes
    {
        double radius;

        public double Radius
        {
            get { return radius; } 
            set 
            {
                if (value < 50) value = 50;
                if (value > 550) value = 550;
                radius = value;
            }
        }

        public Circle(double radius, int start_x, int start_y, int line_widht, Color color)
            :base (start_x, start_y, line_widht, color)
        {
            Radius = radius;
        }
        public double GetDiametr()
        {
            return radius * 2;
        }
        public override double GetArea()
        {
            return radius * radius * Math.PI;
        }
        public override double GetPerimetr()
        {
            return 2 * Math.PI * radius;
        }
        public override void Draw(PaintEventArgs e)
        {
            System.Drawing.Pen pen = new System.Drawing.Pen(Color, LineWht);
            e.Graphics.DrawEllipse(pen, StartX, StartY, (float)GetDiametr(), (float)GetDiametr());
        }
        public override void info(PaintEventArgs e)
        {
            Console.WriteLine( this.GetType());
            base.info(e);
            Console.WriteLine($"Радиус круга: {Radius}");
        }
    }
}
