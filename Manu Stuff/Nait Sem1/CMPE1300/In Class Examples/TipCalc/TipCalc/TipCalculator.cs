using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace TipCalc
{
    class TipCalculator
    {
        static void Main(string[] args)
        {
            double mealAmount = 0.0;
            int tipPercent = 0;
            double tipAmount = 0.0;


            Console.WriteLine("\t\tTip Calculator\n");

            // input the meal amount
            mealAmount = CUtility.GetValue("Enter the cost of the meal: $", 5.00, double.MaxValue);
            //Console.WriteLine(mealAmount);
            //input the tip percentage
            tipPercent = CUtility.GetValue("Enter the tip percentage as a whole number: ", 0, 100);

            //calculate the tip
            tipAmount = CalculateTip(mealAmount, tipPercent);

            //display the amount
            Console.WriteLine("The tip amount is: {0:C}", tipAmount);

            //pause the program
            CUtility.Pause("Press any key to exit the program...");
        }

        static double CalculateTip(double amount, int tipPercent)
        {
            return (amount * ((double)tipPercent / 100.0));
        }
        

    }
}
