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
        public SpeedDialog()
        {
            InitializeComponent();
        }

        public void Speed_Load(object sender, EventArgs e)
        {

        }
        public int trackbarValue = 200;
        
        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            trackbarValue = trackBar1.Value;
        }
    }
}
