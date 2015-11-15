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
            if(Keys.Enter.ToString() == e.KeyChar.ToString());
            {


            }
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
            //make progressbar value equal number of bits (-1 means )



        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            History.Items.Add(webBrowser1.Url.ToString());
            NavigationTxtBox.Text = (webBrowser1.Url.ToString());

        }

        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //use this to show load status of progress bar
            //Collect number of bits to be loaded for webpage and set this as maximum for progressbar
            //make progresbar minimum zero to be sure..?
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
    }
}
