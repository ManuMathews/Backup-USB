using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManuMathews_ICA2
{
    public partial class Form1 : Form
    {
        double hourlyRate = 0.00;
        double hoursWorked = 0;
        double regularHours = 0;
        double overtimeHours = 0;
        double regularPay = 0.00;
        double overtimePay = 0.00;
        double payDue = 0.00;
        bool trueOrFalse0 = true;
        bool trueOrFalse1 = true;
        bool trueOrFalse2 = false;
        int i = 0;
        int j = 0;

        public Form1()
        {
            InitializeComponent();

            if (string.IsNullOrWhiteSpace(tb_HourlyRate.Text) && string.IsNullOrWhiteSpace(tb_HoursWorked.Text))
            {
                trueOrFalse2 = false;
            }
            else
            {
                trueOrFalse2 = true;
            }

            button1.Enabled = trueOrFalse2;

            // *** button1.Enabled = string.IsNullOrWhiteSpace(YourName.Text) :)
        }


        

        private void tb_HourlyRate_TextChanged(object sender, EventArgs e)
        {
            
            if (i >= 1)
            {
                tb_HourlyRate.Clear();
                i = 0;
            }
            //    Console.WriteLine(tb_HourlyRate.Text.ToString());

            if (string.IsNullOrWhiteSpace(tb_HourlyRate.Text) || string.IsNullOrWhiteSpace(tb_HoursWorked.Text))
            {
                trueOrFalse2 = false;
            }
            else
            {
                trueOrFalse2 = true;
            }

            button1.Enabled = trueOrFalse2;
            

        }

        private void tb_HoursWorked_TextChanged(object sender, EventArgs e)
        {
            
            if(j >= 1)
            {
                tb_HoursWorked.Clear();
                j = 0;
            }

            //    Console.WriteLine(tb_HoursWorked.Text.ToString());

            if (string.IsNullOrWhiteSpace(tb_HourlyRate.Text) || string.IsNullOrWhiteSpace(tb_HoursWorked.Text))
            {
                trueOrFalse2 = false;
            }
            else
            {
                trueOrFalse2 = true;
            }

            button1.Enabled = trueOrFalse2;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            i++;
            j++;
            trueOrFalse1 = double.TryParse(tb_HoursWorked.Text, out hoursWorked);
            if (trueOrFalse1 == false)
            {
                MessageBox.Show("Invalid hours worked value");
            }
           // Console.Write("hourly rate:"); Console.WriteLine(hourlyRate);

            if (hoursWorked >= 40)
            {
                regularHours = 40.00;
                overtimeHours = hoursWorked - 40.00;
                lb_RegularHour.Text = (regularHours.ToString());
                lb_OvertimeHours.Text = (overtimeHours.ToString());
            }
         //   Console.WriteLine("regular hours:"); Console.Write(regularHours);
         //   Console.WriteLine("Overtime hours:"); Console.Write(overtimeHours);


            if (hoursWorked < 40)
            {
                regularHours = hoursWorked;
                overtimeHours = 0.00;
                lb_RegularHour.Text = (regularHours.ToString("F1"));
                lb_OvertimeHours.Text = (overtimeHours.ToString("F1"));
            }
        //    Console.WriteLine("regular hours:"); Console.Write(regularHours);
        //    Console.WriteLine("Overtime hours:"); Console.Write(overtimeHours);

            trueOrFalse0 = double.TryParse(tb_HourlyRate.Text, out hourlyRate);
            if (trueOrFalse0 == false)
            {
                MessageBox.Show("Invalid hourly rate value.");
            }

            regularPay = regularHours * hourlyRate;
            overtimePay = overtimeHours * hourlyRate * 1.5;
            payDue = regularPay + overtimePay;

            lb_RegularPay.Text = regularPay.ToString("C");
            lb_OvertimePay.Text = overtimePay.ToString("C");
            lb_PayDue.Text = payDue.ToString("C");

        }

       
    }
}
