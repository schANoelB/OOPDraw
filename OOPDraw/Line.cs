﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    public class Line : Shape
    {

        public Line(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {

        }

        public Line(Pen p, int x1, int y1) : base(p, x1, y1)
        {

        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, X1, Y1, X2, Y2);
        }
    }
}
