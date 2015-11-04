using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsSwitch
{
    class Switch
    {
        static void Main(string[] args)
        {
            string day = "Sun";
            int numValues = 0;
            int sum = 0;
            int input = 0;
            Random rand = new Random

            switch (day)
            {
                case "Mon":
                case "Tue":
                case "Wed":
                case "Thu":
                case "Fri": 

                    Console.WriteLine("Weekday");
                    break;

              
                case "Sat":
                case "Sun":
                    Console.WriteLine("Weekend! Party Time!\a\a\a");
                    break;

                default:
                    Console.WriteLine("Invalid day!");
                    break;
            }

            Console.WriteLine("Enter the number of values to sum: ");
            int.TryParse(Console.ReadLine(), out numValues);

            for (int i = 0; i < numValues; i++)
            {
                Console.Write("Enter a value to sum: ");
                int.TryParse(Console.ReadLine(), out input);

                sum += input;
            }
            Console.WriteLine("The sum is {0}.", sum);

            for (int j = 10; j >= 0; j-- )
            {
                Console.WriteLine(j);
                Console.WriteLine("Hi Mom!");

            }

            Console.WriteLine("Blastoff!");

            for(int k = 0; k < 10; k++)
            {
            numValues = rand.Next(1, 7); // 1 to  6
            Console.WriteLine(numValues);
            }

            Console.Write("Press any key to exit: ");
            Console.ReadKey();
        }
    }
}
