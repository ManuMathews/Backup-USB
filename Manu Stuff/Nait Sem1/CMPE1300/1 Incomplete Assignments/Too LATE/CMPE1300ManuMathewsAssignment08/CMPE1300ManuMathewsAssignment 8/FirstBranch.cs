using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsAssignment_8
{
    class FirstBranch
    {
        static void Main(string[] args)
        {


            bool success = false;
            int dieValue = 0;
            int numberOfDice = 0;
            int i = 0;
            Random randomNumber = new Random();


            Console.WriteLine("Welcome to the Die Value Generator!");
            Console.WriteLine("\nThis program is capable of simulating up to 100 die rolls for a number of \ndifferent games.  Valid dice values are 6, 12, 20, and 100.");

            do
            {
                Console.Write("\nPlease enter the die value you wish to use:  ");
                success = int.TryParse(Console.ReadLine(), out dieValue);
                
               
                if (dieValue == 100 || dieValue == 20 || dieValue == 12 || dieValue == 6)
                {
                    success = true;
                }

                else
                {
                    Console.WriteLine("You have entered an invalid die value!  Please try again.");
                    success = false;
                }
            } while (!success);
            
            success = false;
            
            do
            {
                Console.Write("\nPlease enter the number of dice you wish to roll (1-100):");
                success = int.TryParse(Console.ReadLine(), out numberOfDice);
            } while (!success);


            











            Console.WriteLine("\n\nThank you for using the Die Value Generator!  Goodbye. \n\nPress any key to exit...");

            Console.ReadKey();
        }
    }
}
