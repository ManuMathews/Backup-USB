using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_Lab2
{
    public partial class SpeedDialog : Form
    {
        public  SpeedDialog()
        {
            InitializeComponent();
            trueOrFalse = false;
        }
        public int trackbarValue;


        public void Speed_Load(object sender, EventArgs e)
        {
            trackbarValue = 200;
        }
        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackbarValue = trackBar1.Value;
        }

        public bool trueOrFalse = false;

        private void SpeedDialog_FormClosed(object sender, FormClosedEventArgs e)
        {
            trueOrFalse = true;
        }

        private void SpeedDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
