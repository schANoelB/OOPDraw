﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace OOPDraw
{
    public abstract class Shape
    {
        public abstract void Draw(Graphics g);

        public abstract void GrowTo(int x2, int y2);
    }
}
