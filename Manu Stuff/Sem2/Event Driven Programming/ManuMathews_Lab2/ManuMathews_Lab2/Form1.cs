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


namespace ManuMathews_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CDrawer drawingBoard = new CDrawer();

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            textBox1.Text = "0";
            btn_NewPattern.Focus();
            drawingBoard.Scale = 10;

            byte[,] foregroundArray = new byte[80, 60];   //Reference: Rectangular/two-dimentional arrays
            byte[,] backgroundArray = new byte[80, 60];   //Reference: Rectangular/two-dimentional arrays
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    foregroundArray[i, j] = 0;
                    backgroundArray[i, j] = 0;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameOfLifeUpdates();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            SpeedDialog SpeedDialog1 = new SpeedDialog();
            SpeedDialog1.ShowDialog();

            timer1.Interval = SpeedDialog1.trackbarValue;
        }

        public void GameOfLifeUpdates()
        {
            drawingBoard.Render();
        }
    }
}
