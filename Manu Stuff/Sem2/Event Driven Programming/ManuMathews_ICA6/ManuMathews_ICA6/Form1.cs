using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA6
{
    public partial class Form1 : Form
    {
        int i = 0;
        int time;
        int tickCounter;
        int stopmeasure;

        public Form1()
        {
            InitializeComponent();

            Start.Enabled = false;
            Pause.Enabled = false;
            Reset.Enabled = false;

            numericUpDown1.Maximum = 99;
            numericUpDown1.Minimum = 0;
            numericUpDown1.Value = 0;

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            Start.Enabled = true;

            if (numericUpDown1.Value == 0)
            {
                Start.Enabled = false;
            }

            stopmeasure = int.Parse(numericUpDown1.Value.ToString());
            tickCounter = int.Parse(numericUpDown1.Value.ToString());

            //TimeDisplay.Text = (stopmeasure.ToString("00"));

            //progressBar1.Maximum = int.Parse(numericUpDown1.Value.ToString());
            //progressBar1.Value = int.Parse(numericUpDown1.Value.ToString());


        }

        private void Start_Click(object sender, EventArgs e)
        {
            TimeDisplay.Text = (stopmeasure.ToString("00"));

            progressBar1.Maximum = int.Parse(numericUpDown1.Value.ToString());
            progressBar1.Value = tickCounter;

            timer1.Start();
            time = int.Parse(numericUpDown1.Value.ToString());

            Pause.Enabled = true;
            Start.Enabled = false;
            Reset.Enabled = true;

            numericUpDown1.Enabled = false;
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Pause.Enabled = false;
            Reset.Enabled = true;
            Start.Enabled = true;
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer2.Stop();

            Pause.Enabled = false;
            Reset.Enabled = false;
            Start.Enabled = true;

            numericUpDown1.Enabled = true;

            TimeDisplay.Text = "00";
            tickCounter = 0;

            tickCounter = int.Parse(numericUpDown1.Value.ToString());
            stopmeasure = int.Parse(numericUpDown1.Value.ToString());

            TimeDisplay.Text = (stopmeasure.ToString("00"));

            progressBar1.Value = 0;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(-1);

            if (stopmeasure != 0)
            {
                tickCounter--;
                TimeDisplay.Text = tickCounter.ToString("00");

                stopmeasure--;
            }

            if (tickCounter == 0)
            {
                timer1.Stop();
                timer2.Start();
                i = 0;

                Pause.PerformClick();

                progressBar1.Value = 0;

            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            i++;
            Console.Beep(5000, 100);

            if(i == 10)
            {
                timer2.Stop();
            }
        }
    }
}
