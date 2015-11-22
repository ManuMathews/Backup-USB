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
        public Color()
        {
            InitializeComponent();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void Btn_OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Rbt_Red_CheckedChanged(object sender, EventArgs e)
        {
            Rbt_Green.Checked = false;
            Rbt_Blue.Checked = false;
            //need more stuff here
        }

        private void Rbt_Green_CheckedChanged(object sender, EventArgs e)
        {
            Rbt_Red.Checked = false;
            Rbt_Blue.Checked = false;
            //need more stuff here
        }

        private void Rbt_Blue_CheckedChanged(object sender, EventArgs e)
        {
            Rbt_Green.Checked = false;
            Rbt_Red.Checked = false;
            //need more stuff here
        }
    }
}
