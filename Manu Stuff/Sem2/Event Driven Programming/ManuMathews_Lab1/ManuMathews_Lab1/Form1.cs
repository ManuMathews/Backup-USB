using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_Lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(NavigationTxtBox.Text.ToString());
        }

        private void NavigationTxtBox_TextChanged(object sender, EventArgs e)
        { 
            //nothing needed here
        }

        private void NavigationTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmarks.Items.Add(webBrowser1.Url.ToString());
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Bookmarks.Items.RemoveAt(Bookmarks.SelectedIndex);
        }

        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bookmarks.Items.Clear();
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            //use this to show load status of progress bar
            //Collect number of bits to be loaded for webpage and set this as maximum for progressbar
            //make progresbar minimum zero to be sure..?
            //make progressbar value equal number of bits (-1 means )

            progressBar1.Maximum = (int)e.MaximumProgress + 1;
            progressBar1.Minimum = 0;
            
            try
            {
                if (e.CurrentProgress == -1)
                {
                    progressBar1.Value = 0;
                    Lbl_Loading.Visible = false;
                }
                if (e.CurrentProgress != -1)
                {
                    progressBar1.Value = (int)e.CurrentProgress;
                    Lbl_Loading.Visible = true;
                }
            }
            catch (Exception)
            {

            }
            if(progressBar1.Value == 0)
            {
                Lbl_Loading.Visible = false;
            }
            

        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            History.Items.Add(webBrowser1.Url.ToString());
            NavigationTxtBox.Text = (webBrowser1.Url.ToString());


        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
        }

        private void Home_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("google.ca");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void Forward_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void NavigationTxtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Go.PerformClick();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Items.Clear();
        }
    }
}
