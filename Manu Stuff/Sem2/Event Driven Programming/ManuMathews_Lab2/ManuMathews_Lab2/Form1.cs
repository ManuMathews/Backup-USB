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
        SpeedDialog speedD = new SpeedDialog();

        public void Form1_Load(object sender, EventArgs e)
        {
            btn_Stop.Enabled = false;
            textBox1.Text = "0";
            btn_NewPattern.Focus();
            drawingBoard.Scale = 10;
            freshStart();
        }

        public void freshStart()
        {
            Random randomNumber = new Random();
            numberOfInitallyEnabledPoints = randomNumber.Next(60, 1000);
            btn_Stop.Enabled = false;
            timer1.Stop();

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
                foregroundArray[randomNumber.Next(0, 79), randomNumber.Next(0, 59)] = 1;
            }

            for (int i = 0; i < 79; i++)
            {
                for (int j = 0; j < 59; j++)
                {
                    if (foregroundArray[i, j] == 1) drawingBoard.AddRectangle(i, j, 1, 1, Color.White);
                }
            }

            drawingBoard.Render();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (speedD.trueOrFalse == true) btn_Stop.PerformClick();
            GameOfLifeOneStep();
            timer1.Interval = speedD.trackbarValue;
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            try
            {
                speedD.Show();
                speedD.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Please restart the program to use trackbar.", "Error", MessageBoxButtons.OK);
            }

            timer1.Interval = speedD.trackbarValue;
            timer1.Start();
            btn_Stop.Enabled = true;
        }

        public int numberOfStepsInGOL = 0;

        public void GameOfLifeOneStep()
        {
            numberOfStepsInGOL++;
            textBox1.Text = numberOfStepsInGOL.ToString();
            drawingBoard.Clear();
            for (int i = 0; i < 80; i++)
            {
                for (int j = 0; j < 60; j++)
                {
                    //check to see the number of neighbours (numberOfNeighbours) for foregroundArray[i,j] + Display new background array in drawer.
                    // check all 8 points
                    int numberOfNeighbours = CheckingForNeighbours(i, j);

                    if (foregroundArray[i, j] == 1) backgroundArray[i, j] = 1;

                    //check to see if numberOfNeighbours is lower than 2
                    //    if lower than 2: turn backgroundArray[i,j] to to 0
                    if (numberOfNeighbours < 2) backgroundArray[i, j] = 0;
                    
                    //check to see if numberOfNeighbours is greater than 3
                    //    if greater than 3: backgroundArray[i,j] to to 0
                    if(numberOfNeighbours > 3) backgroundArray[i, j] = 0;

                    //if equal to 3: backgroundArray[i,j] to to 1
                    if(numberOfNeighbours == 3) backgroundArray[i, j] = 1;


                    if (backgroundArray[i,j] == 1) drawingBoard.AddRectangle(i, j, 1,1, Color.White);

                }
            }

            //make foreground equal to background array
            for (int i = 0; i < 79; i++)
            {
                for (int j = 0; j < 59; j++)
                {
                    foregroundArray[i,j] = backgroundArray[i,j];
                }
            }


            //make all background array vaues 0
            for (int i = 0; i < 79; i++)
            {
                for (int j = 0; j < 59; j++)
                {
                    backgroundArray[i, j] = 0;
                }
            }

            drawingBoard.Render();
        }

        public void btn_Draw_Click(object sender, EventArgs e)
        {
            numberOfStepsInGOL = 0;
            textBox1.Text = numberOfStepsInGOL.ToString();
            timer1.Stop();
            btn_Stop.Enabled = false;
            for (int i = 0; i < 79; i++)
            {
                for (int j = 0; j < 59; j++)
                {
                    foregroundArray[i, j] = 0;
                    backgroundArray[i, j] = 0;
                }
            }
            drawingBoard.Clear();
            drawingBoard.Render();

            //add code to receive the click points in a loop
            //add the points to the forground array.. 
            //display the new points
            //end loop




        }

        public int CheckingForNeighbours(int i, int j)
        {
            int noOfNeghs;

            noOfNeghs = 0;
            //look through 8 neighbors: (-1, -1), (-1, 0), (-1, +1), (0, -1), (0, +1), (+1, -1), (+1, 0), (+1, +1)
            
            if((i != 79) && (i != 0) && (j != 59) && (j != 0))
            {
                if (foregroundArray[i - 1, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i - 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i - 1, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j + 1] == 1) noOfNeghs++;
            }

            if((i == 79) && (j == 59))
            {
                if (foregroundArray[78, 58] == 1) noOfNeghs++;
                if (foregroundArray[78, 59] == 1) noOfNeghs++;
                if (foregroundArray[78, 0] == 1) noOfNeghs++; 
                if (foregroundArray[79, 58] == 1) noOfNeghs++;
                if (foregroundArray[79, 0] == 1) noOfNeghs++;
                if (foregroundArray[0, 58] == 1) noOfNeghs++;
                if (foregroundArray[0, 59] == 1) noOfNeghs++;
                if (foregroundArray[0, 0] == 1) noOfNeghs++;
            }

            if ((i == 0) && (j == 0))
            {
                if (foregroundArray[79, 59] == 1) noOfNeghs++;
                if (foregroundArray[79, 0] == 1) noOfNeghs++;
                if (foregroundArray[79, 1] == 1) noOfNeghs++;
                if (foregroundArray[0, 59] == 1) noOfNeghs++;
                if (foregroundArray[0, 1] == 1) noOfNeghs++;
                if (foregroundArray[1, 59] == 1) noOfNeghs++;
                if (foregroundArray[1, 0] == 1) noOfNeghs++;
                if (foregroundArray[1, 1] == 1) noOfNeghs++;
            }

            if ((i == 79) && (j == 0))
            {
                if (foregroundArray[78, 59] == 1) noOfNeghs++;
                if (foregroundArray[78, 0] == 1) noOfNeghs++;
                if (foregroundArray[78, 1] == 1) noOfNeghs++;
                if (foregroundArray[79, 59] == 1) noOfNeghs++;
                if (foregroundArray[79, 1] == 1) noOfNeghs++;
                if (foregroundArray[0, 59] == 1) noOfNeghs++;
                if (foregroundArray[0, 0] == 1) noOfNeghs++;
                if (foregroundArray[0, 1] == 1) noOfNeghs++;
            }

            if ((i == 0) && (j == 59))
            {
                if (foregroundArray[79, 58] == 1) noOfNeghs++;
                if (foregroundArray[79, 59] == 1) noOfNeghs++;
                if (foregroundArray[79, 0] == 1) noOfNeghs++;
                if (foregroundArray[0, 58] == 1) noOfNeghs++;
                if (foregroundArray[0, 0] == 1) noOfNeghs++;
                if (foregroundArray[1, 58] == 1) noOfNeghs++;
                if (foregroundArray[1, 59] == 1) noOfNeghs++;
                if (foregroundArray[1, 0] == 1) noOfNeghs++;
            }

            if ((i == 79) && (j != 59) && (j != 0))
            {
                if (foregroundArray[78, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[78, j] == 1) noOfNeghs++;
                if (foregroundArray[78, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[0, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[0, j] == 1) noOfNeghs++;
                if (foregroundArray[0, j + 1] == 1) noOfNeghs++;
            }

            if ((i != 79) && (i != 0) && (j == 59))
            {
                if (foregroundArray[i - 1, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i - 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i - 1, 0] == 1) noOfNeghs++;
                if (foregroundArray[i, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i, 0] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, 0] == 1) noOfNeghs++;
            }


            if ((i == 0) && (j != 59) && (j != 0))
            {
                if (foregroundArray[79, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[79, j] == 1) noOfNeghs++;
                if (foregroundArray[79, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j - 1] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j + 1] == 1) noOfNeghs++;
            }

            if ((i != 79) && (i != 0) && (j == 0))
            {
                //refine/edit accordingly
                if (foregroundArray[i - 1, 59] == 1) noOfNeghs++;
                if (foregroundArray[i - 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i - 1, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i, 59] == 1) noOfNeghs++;
                if (foregroundArray[i, j + 1] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, 59] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j] == 1) noOfNeghs++;
                if (foregroundArray[i + 1, j + 1] == 1) noOfNeghs++;
            }


            return noOfNeghs;
        }

        private void btn_Cycle_Click(object sender, EventArgs e)
        {
            GameOfLifeOneStep();

        }

        private void btn_NewPattern_Click(object sender, EventArgs e)
        {
            numberOfStepsInGOL = 0;
            textBox1.Text = numberOfStepsInGOL.ToString();
            drawingBoard.Clear();
            foregroundArray = backgroundArray;
            freshStart();
        }

        public void btn_Stop_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            speedD.Visible = false;
        }

        public  void Pause()
        {
           btn_Stop.PerformClick();
        }
    }
}
