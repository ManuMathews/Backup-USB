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
    public partial class Color : Form
    {
        //common variables
        public System.Drawing.Color circleColor = System.Drawing.Color.Red;
        public Color()
        {
            InitializeComponent();
            if(Form1.circleColor == System.Drawing.Color.Red)
            {
                Rbt_Red.Checked = true;
            }
            if (Form1.circleColor == System.Drawing.Color.Green)
            {
                Rbt_Green.Checked = true;
            }
            if (Form1.circleColor == System.Drawing.Color.Blue)
            {
                Rbt_Blue.Checked = true;
            }
        }

        public void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public void Rbt_Red_CheckedChanged(object sender, EventArgs e)
        {
            circleColor = System.Drawing.Color.Red;
            //need more stuff here
        }

        public void Rbt_Green_CheckedChanged(object sender, EventArgs e)
        {
            circleColor = System.Drawing.Color.Green;
            //need more stuff here
        }

        public void Rbt_Blue_CheckedChanged(object sender, EventArgs e)
        {
            circleColor = System.Drawing.Color.Blue;
            //need more stuff here
        }
    }
}
