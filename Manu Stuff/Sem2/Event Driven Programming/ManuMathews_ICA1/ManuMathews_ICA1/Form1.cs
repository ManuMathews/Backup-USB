using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA1
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            Console.WriteLine("Form is Initializing");
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            Console.WriteLine("The form is being resized");
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Console.WriteLine("The form has been resized");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("The form is closing.");
            e.Cancel = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Console.WriteLine("The form was closed.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("The form is Loading.");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            i++;
            Text = i.ToString();
            Console.WriteLine("Paint event is occuring.");
            this.Text = Text + "paint events happened";
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Console.WriteLine("The Form is being shown.");
        }

        

    }
}
