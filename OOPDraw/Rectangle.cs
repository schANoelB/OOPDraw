﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    class Rectangle : Shape
    {

        public Rectangle(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {

        }

        public Rectangle(Pen p, int x1, int y1) : base(p, x1, y1)
        {
        }

        public override void Draw(Graphics g)
        {
            (int x, int y, int w, int h) = EnclosingRectangle();
            g.DrawRectangle(Pen, x, y, w, h);
        }
    }
}
