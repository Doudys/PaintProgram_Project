using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace PaintProgram_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
        }

        bool canPaint = false;
        Graphics g;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            canPaint = true;

            if ((drawCircle = true) || (drawSquare = true) || (drawRectangle = true))
            {
               // SolidBrush s = new SolidBrush(toolStripButton1.BackColor);

                if (String.IsNullOrEmpty(toolStrip_TextBox_ShapeSize.Text))
                {
                    MessageBox.Show("Please enter a shape size", "Shape Size", MessageBoxButtons.OK);
                    return;
                }
            }

            
            if (drawSquare)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.BackColor);// Must try to make global to avoid code duplication...
                g.FillRectangle(s, e.X, e.Y, Int32.Parse(toolStrip_TextBox_ShapeSize.Text), Int32.Parse(toolStrip_TextBox_ShapeSize.Text));
                drawSquare = false;
            }
            else if (drawRectangle)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.BackColor);
                g.FillRectangle(s, e.X, e.Y, Int32.Parse(toolStrip_TextBox_ShapeSize.Text) * 2, Int32.Parse(toolStrip_TextBox_ShapeSize.Text));
                drawRectangle = false;
            }
            else if (drawCircle)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.BackColor);
                g.FillEllipse(s, e.X, e.Y, (Int32.Parse(toolStrip_TextBox_ShapeSize.Text) * 2) , Int32.Parse(toolStrip_TextBox_ShapeSize.Text));
                drawCircle = false;
            }

            canPaint = false;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            canPaint = false;
            prevx = null;
            prevy = null;
        }


        int? prevx = null;
        int? prevy = null;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (canPaint)
            {
                    Pen pen = new Pen(toolStripButton1.BackColor, Int16.Parse(PenSize_toolstrip.Text));

                    g.DrawLine(pen, new Point(prevx ?? e.X, prevy ?? e.Y), new Point(e.X, e.Y));

                    prevx = e.X;
                    prevy = e.Y;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog(); // opens the color dialog window
            if (cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton1.BackColor = cd.Color;
            }

        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            g.Clear(panel1.BackColor);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog(); // opens the color dialog window
            if (cd.ShowDialog() == DialogResult.OK)
            {
                toolStripButton3.BackColor = cd.Color;
                panel1.BackColor = cd.Color;
            }
        }

        bool drawSquare = false;
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        bool drawRectangle = false;
        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        bool drawCircle = false;
        private void cirleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }


    }
}
