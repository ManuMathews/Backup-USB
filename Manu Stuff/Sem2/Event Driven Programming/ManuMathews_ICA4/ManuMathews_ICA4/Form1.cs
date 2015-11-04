using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA4
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Minimum = 0;
            numericUpDown1.Maximum = listBox1.Items.Count;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Delete.Enabled = false;
            numericUpDown1.Enabled = false;
        }


        public void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            numericUpDown1.Maximum = listBox1.Items.Count;
            textBox1.Clear();
            textBox1.Focus();
            listBox1.SelectedIndex = listBox1.Items.Count - 1;
            numericUpDown1.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (listBox1.SelectedIndex <= -1)
            {
                MessageBox.Show("Please select the item you want to delete.");
            }

            listBox1.Items.Remove(listBox1.SelectedItem);
            numericUpDown1.Maximum = listBox1.Items.Count;

            if (listBox1.Items.Count >= 1)
            {
                listBox1.SelectedIndex = 0;
            }

            if (listBox1.SelectedIndex <= -1)
            {
                Delete.Enabled = false;
                numericUpDown1.Enabled = false;
            }
        }

        int i = 0;


        private void Find_Click(object sender, EventArgs e)
        {
            string stringy = listBox1.Text;
            bool trueOrFalse = string.IsNullOrWhiteSpace(textBox1.Text);



            if (trueOrFalse == true)
            {
            }

            if (trueOrFalse == false)
            {
                i = listBox1.FindString(textBox1.Text);

                if (i != -1)
                {

                    FoundAt.Text = (listBox1.FindString(textBox1.Text) + 1).ToString();
                    SelectedItem.Text = listBox1.SelectedItem.ToString();
                   // SelectedItem.Text = listBox1.SelectedItems.ToString();
                    listBox1.SelectedIndex = i;
                    Delete.Enabled = true;

                }



                if (i == -1)
                {
                    SelectedItem.Text = "Not Found";
                    FoundAt.Text = "Not Found";
                    textBox1.Focus();
                }

            }

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Delete.Enabled = true;
            numericUpDown1.Maximum = listBox1.Items.Count;
            listBox1.SelectedIndex = (int)numericUpDown1.Value - 1;
            if (listBox1.SelectedIndex >= 0)
            {
                FoundAt.Text = (listBox1.SelectedIndex + 1).ToString();

            }
            if (listBox1.SelectedIndex == -1)
            {
                FoundAt.Text = "No items selected";
                textBox1.Focus();
            }

        }



        //private void TBx_Top_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        TBx_Bottom.Focus();
        //    }
        //}

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                        
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex < 0)
            {
                SelectedItem.Text = "No items selected";
                FoundAt.Text = "No Items Selected";
                numericUpDown1.Value = 0;
            }

            if (listBox1.SelectedIndex >= 0)
            {
                SelectedItem.Text = listBox1.SelectedItem.ToString();
                FoundAt.Text = (listBox1.SelectedIndex + 1).ToString();
                Delete.Enabled = true;
                numericUpDown1.Value = listBox1.SelectedIndex + 1;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Add.PerformClick();
                
            }

        }
    }
}
