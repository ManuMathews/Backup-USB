using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GDIDrawer;

namespace ManuMathews_ICA7
{
    public partial class Form1 : Form
    {

        CDrawer canvas = new CDrawer(600, 600);
        public Form1()
        {
            InitializeComponent();
        }
        int xStart = 300;
        int yStart = 300;
        int circleDiameter = 20;
        int borderThickness = 0;
        int keyMoveDistance = 20;
        Color borderColor = Color.White;
        Color circleColor = Color.Red;


        private void Form1_Load(object sender, EventArgs e)
        {

            canvas.AddEllipse(xStart, yStart, circleDiameter, circleDiameter, circleColor, borderThickness, borderColor);
            



        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                keyMoveDistance = 40;
            }

            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                keyMoveDistance = 60;
            }

            if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
            {
                keyMoveDistance = 80;
            }

            if (e.KeyCode == Keys.F1)
            {
                borderThickness = 1;
            }


            if (e.KeyCode == Keys.Up)
            {
                if ((yStart - keyMoveDistance) >= 0)
                {
                    yStart = yStart - keyMoveDistance;

                    canvas.AddEllipse(xStart, yStart, circleDiameter, circleDiameter, circleColor, borderThickness, borderColor);
                }
            }

            if (e.KeyCode == Keys.Down)
            {
                if ((yStart + keyMoveDistance) < 600)
                {
                    yStart = yStart + keyMoveDistance;

                    canvas.AddEllipse(xStart, yStart, circleDiameter, circleDiameter, circleColor, borderThickness, borderColor);
                }
            }

            if (e.KeyCode == Keys.Left)
            {
                if ((xStart - keyMoveDistance) >= 0)
                {
                    xStart = xStart - keyMoveDistance;

                    canvas.AddEllipse(xStart, yStart, circleDiameter, circleDiameter, circleColor, borderThickness, borderColor);
                }
            }

            if (e.KeyCode == Keys.Right)
            {
                if ((xStart + keyMoveDistance) < 600)
                {
                    xStart = xStart + keyMoveDistance;

                    canvas.AddEllipse(xStart, yStart, circleDiameter, circleDiameter, circleColor, borderThickness, borderColor);
                }
            }



            if (e.KeyCode == Keys.B)
            {
                circleColor = Color.Blue;
            }

            if (e.KeyCode == Keys.R)
            {
                circleColor = Color.Red;
            }

            if (e.KeyCode == Keys.G)
            {
                circleColor = Color.Green;
            }



            if(e.KeyCode == Keys.X)
            {
                Application.Exit();
            }


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                borderThickness = 0;
            }

            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                keyMoveDistance = 20;
            }

            if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
            {
                keyMoveDistance = 20;
            }

            if ((Control.ModifierKeys & Keys.Alt) == Keys.Alt)
            {
                keyMoveDistance = 20;
            }


        }
    }
}
