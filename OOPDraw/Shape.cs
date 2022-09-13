using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape
    {
        protected internal Pen Pen { get; set; }

        protected int X1 { get; set; }

        protected int X2 { get; set; }

        protected int Y1 { get; set; }

        protected int Y2 { get; set; }

        public Shape(Pen p, int x1, int y1, int x2, int y2)
        {
            Pen = p;
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
        }

        public Shape(Pen p, int x1, int y1) : this(p, x1, y1, x1, y1)
        { 
        }

        public abstract void Draw(Graphics g);

        public virtual void GrowTo(int x2, int y2)
        {
            X2 = x2;
            Y2 = y2;
        }

        public (int, int, int, int) EnclosingRectangle()
        {
            int x = Math.Min(X1, X2);
            int y = Math.Min(Y1, Y2);
            int w = Math.Max(X1, X2) - x;
            int h = Math.Max(Y1, Y2) - y;
            return (x, y, w, h);
        }

        public void MoveBy(int xDelta, int yDelta)
        {
            X1 += xDelta;
            Y1 += yDelta;
            X2 += xDelta;
            Y2 += yDelta;
        }
    }
}
