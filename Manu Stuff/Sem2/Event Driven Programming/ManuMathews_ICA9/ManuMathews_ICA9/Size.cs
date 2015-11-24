using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA9
{
    public partial class Size : Form
    {
        public int circleSize = 10;
        public Size()
        {
            InitializeComponent();
            trackBar1.Value = Form1.circleSize;
        }

        public void btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        public void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void trackBar1_Scroll(object sender, EventArgs e)
        {
            circleSize = trackBar1.Value;
        }
    }
}
