using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();



            /*
            radiobutton1 ==> selects small car
            radiobutton2 ==> selects midsize car
            radiobutton3 ==> selects sports car

            label3 => shows total calculated amount to user.

            */



            if (string.IsNullOrWhiteSpace(textBox1.Text) == true)
            {
                CarType.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                INSCst.Enabled = false;
                AMADisc.Enabled = false;
                numericUpDown1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
            }
            for (int i = 0; i < 1; i++)
            {
                radioButton1.Checked = true;

            }





        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 0;



            if (string.IsNullOrWhiteSpace(textBox1.Text) == true)
            {
                CarType.Enabled = false;
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                INSCst.Enabled = false;
                AMADisc.Enabled = false;
                numericUpDown1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
            

                numberOfDays = (int)numericUpDown1.Value;


                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if(radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                if (INSCst.Checked != true)
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");


            }
        }






        private void INSCst_CheckedChanged(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;

            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;



                numberOfDays = (int)numericUpDown1.Value;


                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");


            }
        }



        private void AMADisc_CheckedChanged(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;


            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;



                numberOfDays = (int)numericUpDown1.Value;


                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;


            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;



                numberOfDays = (int)numericUpDown1.Value;


                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");

            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;


            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;




                numberOfDays = (int)numericUpDown1.Value;


                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");

            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;


            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;


                numberOfDays = (int)numericUpDown1.Value;



                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");

            }
        }





        private void radioButton3_CheckedChanged(object sender, EventArgs e)

        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;


            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;


                numberOfDays = (int)numericUpDown1.Value;


                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");

            }
        }




        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // String Variables:

            // number variables that should not be changed:
            double smallPerDay = 40.00; //cost per day for small cars
            double midsizePerDay = 50.00; //cost per day for Midsize cars
            double sportsPerDay = 60.00; //cost per day for Sports cars
            double insurancePerDay = 15.00; //cost per day for insurance

            // number variables that should change
            double totalCost = 0.00; // to be calculated and shown to the user
            double carSpecificCost = 0.00; // to be selected according to users car type selection
            double totalInsureanceCost = 0.00;
            double amaDiscount = 0.00;
            int numberOfDays = 1;


            if (string.IsNullOrWhiteSpace(textBox1.Text) != true)
            {
                CarType.Enabled = true;
                radioButton1.Enabled = true;
                radioButton2.Enabled = true;
                radioButton3.Enabled = true;
                INSCst.Enabled = true;
                AMADisc.Enabled = true;
                numericUpDown1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;


                numberOfDays = (int)numericUpDown1.Value;



                if (radioButton1.Checked == true)
                {
                    carSpecificCost = smallPerDay * numberOfDays;
                }
                if (radioButton2.Checked == true)
                {
                    carSpecificCost = midsizePerDay * numberOfDays;
                }
                if (radioButton3.Checked == true)
                {
                    carSpecificCost = sportsPerDay * numberOfDays;
                }
                if (radioButton1.Checked == false && radioButton2.Checked == false && radioButton3.Checked == false)
                {
                    radioButton1.Checked = true;
                    carSpecificCost = smallPerDay * numberOfDays;
                }



                if (INSCst.Checked == true)
                {
                    totalInsureanceCost = insurancePerDay * numberOfDays;
                }
                else
                {
                    totalInsureanceCost = 0;
                }



                if (AMADisc.Checked == true)
                {
                    amaDiscount = 0.90;
                }
                else
                {
                    amaDiscount = 1.00;
                }

                totalCost = (carSpecificCost + totalInsureanceCost) * amaDiscount;

                label3.Text = "Total  " + totalCost.ToString("C");

            }
        }
    }
}