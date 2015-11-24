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


namespace ManuMathews_ICA9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //common stuff(to be used throught the program)
        public static int circleSize = 10;
        public static System.Drawing.Color circleColor = System.Drawing.Color.Red;

        public CDrawer drawingBoard = new CDrawer();


        public void button1_Click(object sender, EventArgs e)//Size button
        {
            Size newSize = new Size();
            if (DialogResult.OK == newSize.ShowDialog())
            {
                
                circleSize = newSize.circleSize;

            }
        }

        public void button2_Click(object sender, EventArgs e)//Color Button
        {
            Color newColor = new Color();
            if (DialogResult.OK == newColor.ShowDialog())
            {
                circleColor = newColor.circleColor;
            }
        }

        public void timer1_Tick(object sender, EventArgs e)
        {
            Point newCirclePoint;
            if(true == drawingBoard.GetLastMouseLeftClick(out newCirclePoint))
            {
                drawingBoard.AddEllipse(newCirclePoint.X - (circleSize/2), newCirclePoint.Y - (circleSize / 2), circleSize, circleSize, circleColor);
            }
        }
    }
}
