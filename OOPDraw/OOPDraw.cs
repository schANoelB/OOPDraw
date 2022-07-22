﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPDraw
{
    public partial class OOPDraw : Form
    {
        public OOPDraw()
        {
            InitializeComponent();
            DoubleBuffered = true; //Stops image flickering
            LineWidth.SelectedItem = "Medium";
            Colour.SelectedItem = "Green";
            Shape.SelectedItem = "Line";
        }

        Pen currentPen = new Pen(Color.Black);
        bool dragging = false;
        Point startOfDrag = Point.Empty;
        Point lastMousePosition = Point.Empty;
        List<Object> shapes = new List<Object>();

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            
            foreach (dynamic shape in shapes)
            {
                shape.Draw(gr);
            }
        }

        private void Canvas_MouseDown(object sender, MouseEventArgs e)

        {
            dragging = true;
            startOfDrag = lastMousePosition = e.Location;
            switch (Shape.Text)
            {
                case "Line":
                    shapes.Add(new Line(currentPen, e.X, e.Y));
                    break;
                case "Rectangle":
                    shapes.Add(new Rectangle(currentPen, e.X, e.Y));
                    break;
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging) 
            {
                dynamic shape = shapes.Last();
                shape.GrowTo(e.X, e.Y);
                lastMousePosition = e.Location; 
                Refresh(); 
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void LineWidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            float width = currentPen.Width;
            switch (LineWidth.Text)
            {
                case "Thin":
                    width = 2.0F;
                    break;
                case "Medium":
                    width = 4.0F;
                    break;
                case "Thick":
                    width = 8.0F;
                    break;
            }
            currentPen = new Pen(currentPen.Color, width);
        }

        private void Colour_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color colour = currentPen.Color;
            switch (Colour.Text)
            {
                case "Red":
                    colour = Color.Red;
                    break;
                case "Green":
                    colour = Color.Green;
                    break;
                case "Blue":
                    colour = Color.Blue;
                    break;
            }
            currentPen = new Pen(colour, currentPen.Width);
        }
    }
}
