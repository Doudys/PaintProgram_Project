using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
<<<<<<< HEAD
using System.Drawing.Drawing2D;
=======
>>>>>>> dbc40ab24e5d72c5621107f5f286f88a7e93c28b

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
<<<<<<< HEAD

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
=======
            if (drawSquare)
            {
                SolidBrush s = new SolidBrush(toolStripButton1.BackColor);
                g.FillRectangle(s, e.X, e.Y, 50, 50);
                canPaint = false;
                drawSquare = false;
            }
>>>>>>> dbc40ab24e5d72c5621107f5f286f88a7e93c28b
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
<<<<<<< HEAD
                    Pen pen = new Pen(toolStripButton1.BackColor, Int16.Parse(PenSize_toolstrip.Text));
=======
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
>>>>>>> dbc40ab24e5d72c5621107f5f286f88a7e93c28b

                    g.DrawLine(pen, new Point(prevx ?? e.X, prevy ?? e.Y), new Point(e.X, e.Y));

                    prevx = e.X;
                    prevy = e.Y;
<<<<<<< HEAD
=======
                //}
>>>>>>> dbc40ab24e5d72c5621107f5f286f88a7e93c28b
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
<<<<<<< HEAD
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


=======
            bool drawSquare = true;
        }
>>>>>>> dbc40ab24e5d72c5621107f5f286f88a7e93c28b
    }
}
