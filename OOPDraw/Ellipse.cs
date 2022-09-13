﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace OOPDraw
{
    public class Ellipse : Shape
    {
        public Ellipse(Pen p, int x1, int y1) : base(p, x1, y1)
        {
        }

        public Ellipse(Pen p, int x1, int y1, int x2, int y2) : base(p, x1, y1, x2, y2)
        {
        }

        public override void Draw(Graphics g)
        {
            (int x, int y, int w, int h) = EnclosingEllipse();
            if (w > 0 && h > 0)
            {
                g.DrawArc(Pen, x, y, w, h, 0F, 360F);
            }
        }
    }
}
