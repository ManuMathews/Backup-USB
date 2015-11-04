using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP1300ManuMathewsPopCalculator
{
    class PopCalculator
    {
        static void Main(string[] args)
        {
            int numberOfCans = 0;
            string input;
            bool success;
            int cases = 0;
            int looseCans = 0;
           
            do
            {
                Console.Write("How many cans of pop to purchase? ");
                input = Console.ReadLine();

            success = int.TryParse(input, out numberOfCans); 
            if(success == false)
            {
                Console.WriteLine("Incorrect number of cans was entered");
            }

            } while (!success);

            cases = numberOfCans / 12;
            looseCans = numberOfCans % 12;

            Console.WriteLine("you need to buy {0} cases and {1} loose cans.", cases, looseCans);

            Console.Write("Press any key to exit:");


            Console.ReadKey();
        }
    }
}
