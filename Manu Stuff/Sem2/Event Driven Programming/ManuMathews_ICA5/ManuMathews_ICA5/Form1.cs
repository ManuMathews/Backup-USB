using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA5
{
    public partial class Form1 : Form
    {
        bool trueOrFalse1 = true;

        SaveFileDialog SaveDialogBox = new SaveFileDialog();
        string file = null;
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if its empty
            if (trueOrFalse1  == false || richTextBox1.Text.Length != 0)
            {
                DialogResult yesOrNoDialog;
                yesOrNoDialog = MessageBox.Show("Are you sure you want to discard any changes?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (yesOrNoDialog == DialogResult.Yes)
                {
                    richTextBox1.Clear();
                    file = null;
                    Text = "Untitled - MiniEdit";
                }

            }
            if (trueOrFalse1 == true)
            {

                richTextBox1.Clear();
                file = null;
                Text = "Untitled - MiniEdit";


            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //if its empty
            if (trueOrFalse1 == false)
            {
                DialogResult yesOrNoDialog;
                yesOrNoDialog = MessageBox.Show("Are you sure you want to discard any changes?", " ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (yesOrNoDialog == DialogResult.Yes)
                {
                    OpenFileDialog dialogBox1 = new OpenFileDialog();
                    dialogBox1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                    dialogBox1.FilterIndex = 1;

                    if (dialogBox1.ShowDialog() == DialogResult.OK)
                    {
                        string file = dialogBox1.FileName;

                        StreamReader FileReader;

                        try
                        {
                            FileReader = new StreamReader(file);
                            richTextBox1.Text = FileReader.ReadToEnd().ToString();
                            FileReader.Close();
                            trueOrFalse1 = true;
                        }
                        catch
                        {
                            MessageBox.Show("File Error: Problem reading input file for the display...");
                        }
                    }
                    
                }

                if (yesOrNoDialog == DialogResult.No)
                {
                    //nothing needed here.
                }
                if (yesOrNoDialog == DialogResult.Cancel)
                {
                    //nothing needed here.
                }

            }

            else
            {
                OpenFileDialog dialogBox1 = new OpenFileDialog();
                dialogBox1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
                dialogBox1.FilterIndex = 1;

                if (dialogBox1.ShowDialog() == DialogResult.OK)
                {
                    file = dialogBox1.FileName;

                    StreamReader FileReader;

                    try
                    {
                        FileReader = new StreamReader(file);
                        richTextBox1.Text = FileReader.ReadToEnd().ToString();
                        FileReader.Close();
                        trueOrFalse1 = true;

                    }
                    catch
                    {
                        MessageBox.Show("File Error: Problem reading input file for the display...");
                    }
                    string[] fileInPieces = file.Split('\\');
                    Text = fileInPieces[fileInPieces.Length - 1] + " - MiniEdit";

                }

            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (file != null)
            {
                StreamWriter strmWriter = new StreamWriter(file);
                strmWriter.Write(richTextBox1.Text);
                strmWriter.Close();
                trueOrFalse1 = true;

            }


            else
            {
                SaveDialogBox.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";


                if (SaveDialogBox.ShowDialog() == DialogResult.OK)
                {
                    string file =  SaveDialogBox.FileName;
                    StreamWriter strmWriter = new StreamWriter(file);

                    strmWriter.Write(richTextBox1.Text);

                    strmWriter.Close();
                    trueOrFalse1 = true;

                    string[] fileInPieces = file.Split('\\');
                    Text = fileInPieces[fileInPieces.Length - 1] + " - MiniEdit";
                }

            }
            

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDialogBox = new SaveFileDialog();
            SaveDialogBox.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            

            if (SaveDialogBox.ShowDialog() == DialogResult.OK)
            {
                file = SaveDialogBox.FileName;
                StreamWriter strmWriter = new StreamWriter(file);
                strmWriter.Write(richTextBox1.Text);

                strmWriter.Close();
                trueOrFalse1 = true;

                string[] fileInPieces = file.Split('\\');
                Text = fileInPieces[fileInPieces.Length - 1] + " - MiniEdit";
            }
        }


        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            


        }

        

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if its empty
            if (richTextBox1.Text.Length == 0 || trueOrFalse1 == true)
            {
                ActiveForm.Close();
            }

            //if it has contents
            if (richTextBox1.Text.Length >= 1 && trueOrFalse1 == false)
            {
                DialogResult exit = MessageBox.Show("Are you sure you want to disgard unsaved data?", "Mini Edit", MessageBoxButtons.YesNo);
                if(exit == DialogResult.Yes)
                {
                    ActiveForm.Close();
                }

            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
                trueOrFalse1 = false;
        }

    }
}
