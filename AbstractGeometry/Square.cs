﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractGeometry
{
    internal class Square:Regtangle
    {
        //double side; 
        public Square(double side, int start_x, int start_y, int line_widht, Color color) 
            :base(side,side, start_x, start_y, line_widht, color) { }



    }
}
