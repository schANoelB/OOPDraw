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
            DrawingFunctions.DrawClosedArc(g, this);
        }
    }
}
