using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuLab2Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCans = 0, cases = 0, loose = 0;
            double totalCost = 0.0;
            Console.WriteLine("\t\tQuestion 1");
            do
            {
                totalCans = GetCans();
                cases = CalculateCases(totalCans);
                loose = CalculateLoose(totalCans);
                totalCost = CalculateTotal(cases, loose);
                DisplayTotal(totalCost, cases, loose);
            } while (RunAgain());
         }

        static int GetCans()
        {
            string inputNumberOfCans;
            int numberOfCans;
            bool success = false;
            do
            {
                Console.Write("\nEnter the number of Cans to purchase: ");
                inputNumberOfCans = Console.ReadLine();
                success = int.TryParse(inputNumberOfCans, out numberOfCans);
            }while(!success);
            return numberOfCans;
        }

        static int CalculateCases(int totalCans)
        {
            int numberOfCases = totalCans / 12;
            return numberOfCases;
        }

        static int CalculateLoose(int totalCans)
        {
            int numberOfLoose = totalCans % 12;
            return numberOfLoose;
        }

        static double CalculateTotal(int cases, int loose)
        {
            double totalCost = (cases * 5.00) + (loose * 0.50);
            return totalCost;
        }

        static void DisplayTotal(double totalCost,int cases,int loose)
        {
            Console.WriteLine("You require {0} cases, {1} loose cans, for a total of {2:C}", cases, loose, totalCost);
        }
        
        static bool RunAgain()
        {
            bool success = true;
            Console.Write("enter y to run again");
            string input = Console.ReadLine();
            input = input.ToLower();
            input = input.Trim();

            if(input == "y")
            {
                success = true;
            }

            else
            {
                success = false;
            }
            return success;
        }

    }
}
