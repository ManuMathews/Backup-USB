using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsInputFun
{
    class InputFun
    {
        static void Main(string[] args)
        {
            int age = 0;
            int daysLived = 0;
            string input;
            bool success = false;

            do
            {
                Console.Write("Write your name in years: ");

                input = Console.ReadLine();

                success = int.TryParse(input, out age);

                if(success == false)
                {
                    Console.WriteLine("Incorrect number was entered. Please try again.");
                }
            }
            while (!success);

            daysLived = age * 365;

            Console.WriteLine("You are {0} years old, and have lived {1} days.", age, daysLived);

            Console.ReadKey();




        }
    }
}
