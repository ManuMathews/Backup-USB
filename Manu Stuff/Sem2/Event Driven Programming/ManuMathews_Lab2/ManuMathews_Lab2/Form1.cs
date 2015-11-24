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
        public byte[,] foregroundArray;
        public byte[,] backgroundArray;
        int numberOfInitallyEnabledPoints = 0;

        public void Form1_Load(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            textBox1.Text = "0";
            btn_NewPattern.Focus();
            drawingBoard.Scale = 10;
            Random randomNumber = new Random();
            numberOfInitallyEnabledPoints = randomNumber.Next(0, 300);
            
            foregroundArray = new byte[80, 60];   //Reference: Rectangular/two-dimentional arrays
            backgroundArray = new byte[80, 60];   //Reference: Rectangular/two-dimentional arrays
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    foregroundArray[i, j] = 0;
                    backgroundArray[i, j] = 0;
                }
            }

            for (int i = 0; i < numberOfInitallyEnabledPoints; i++)
            {
                foregroundArray[randomNumber.Next(1, 80), randomNumber.Next(1, 60)] = 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GameOfLifeOneStep();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            SpeedDialog SpeedDialog1 = new SpeedDialog();
            SpeedDialog1.ShowDialog();

            timer1.Interval = SpeedDialog1.trackbarValue;
        }
        

        public void GameOfLifeOneStep()
        {
            //backgroundArray and foregroundArray are commonly available to all methods **

            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    //check to see the number of neighbours (numberOfNeighbours) for foregroundArray[i,j]
                    // check all 8 points
                    int numberOfNeighbours = CheckingForNeighbours(i, j);

                    //check to see if numberOfNeighbours is lower than 2
                    //    if lower than 2: turn backgroundArray[i,j] to to 0
                    if(numberOfNeighbours < 2)backgroundArray[i, j] = 0;
                    
                    //check to see if numberOfNeighbours is greater than 3
                    //    if greater than 3: backgroundArray[i,j] to to 0
                    if(numberOfNeighbours > 3) backgroundArray[i, j] = 0;

                    //if equal to 3:
                    //    backgroundArray[i,j] to to 1
                    if (numberOfNeighbours == 3) backgroundArray[i, j] = 1;

                }
            }

            //display the new background array in drawer;

            //make foreground equal to background array
            foregroundArray = backgroundArray;

            //make all background array vaues 0
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    backgroundArray[i, j] = 0;
                }
            }

            drawingBoard.Render();
        }


        public void btn_Draw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    foregroundArray[i, j] = 0;
                    backgroundArray[i, j] = 0;
                }
            }
            drawingBoard.Clear();
        }


        public int CheckingForNeighbours(int i, int j)
        {
            int noOfNeghs = 0;
            //look through 8 neighbors: (-1, -1), (-1, 0), (-1, +1), (0, -1), (0, +1), (+1, -1), (+1, 0), (+1, +1)

            if (foregroundArray[i - 1, j - 1] == 1) noOfNeghs++;
            if (foregroundArray[i - 1, j] == 1) noOfNeghs++;
            if (foregroundArray[i - 1, j + 1] == 1) noOfNeghs++;
            if (foregroundArray[i, j - 1] == 1) noOfNeghs++;
            if (foregroundArray[i, j + 1] == 1) noOfNeghs++;
            if (foregroundArray[i + 1, j - 1] == 1) noOfNeghs++;
            if (foregroundArray[i + 1, j] == 1) noOfNeghs++;
            if (foregroundArray[i + 1, j + 1] == 1) noOfNeghs++;

            return noOfNeghs;
        }

    }
}
