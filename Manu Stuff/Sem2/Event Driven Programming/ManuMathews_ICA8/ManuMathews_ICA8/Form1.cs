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

namespace ManuMathews_ICA8
{
    public struct CircleParams
    {
        Point circleCentreLocation;
        int circleDiameter;
        Color circleColor;
        
    }

    public partial class Form1 : Form
    {
        CDrawer drawer;
        public Form1()
        {
            InitializeComponent();
            drawer = new CDrawer(800, 600, false);
        }

        ColorDialog colorDialog = new ColorDialog();

        //Common Variables:
        int size = 10;
        Point clickCoordinates;
        Color color = Color.White;
        
        



        private void btn_StartDraw_Click(object sender, EventArgs e)
        {
            drawer.GetLastMouseLeftClick(out clickCoordinates);
            drawer.AddEllipse((clickCoordinates.X - (size / 2)), (clickCoordinates.Y - (size / 2)), size, size, color);
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                color = colorDialog.Color;
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            size = trackBar1.Value;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_Load_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (bRes)                                            // new coords?    
            {
                drawer.AddEllipse(pCoord.X - 10, pCoord.Y - 10, 20, 20);

            }

        drawer.ContinuousUpdate = true;
            drawer.ContinuousUpdate = false;
        }
    }
}
