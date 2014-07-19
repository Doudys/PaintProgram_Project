using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            if (drawSquare)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.BackColor);
                g.FillRectangle(s, e.X, e.Y, 50, 50);
                canPaint = false;
                drawSquare = false;
            }
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
                //SolidBrush s = new SolidBrush(Color.Black);
                //g.FillEllipse(s
                //            , e.X
                //            , e.Y
                //            , Convert.ToInt32(PenSize_toolstrip.Text)
                //            , Convert.ToInt32(PenSize_toolstrip.Text));

                //if (String.IsNullOrEmpty(PenSize_toolstrip.Text) == true)
                //{
                //    MessageBox.Show("Please enter a pen size", "Pen Size", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    return;
                //}

                //else
                //{
                    Pen pen = new Pen(toolStripButton1.BackColor, float.Parse(PenSize_toolstrip.Text));

                    g.DrawLine(pen, new Point(prevx ?? e.X, prevy ?? e.Y), new Point(e.X, e.Y));

                    prevx = e.X;
                    prevy = e.Y;
                //}
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
            bool drawSquare = true;
        }
    }
}
