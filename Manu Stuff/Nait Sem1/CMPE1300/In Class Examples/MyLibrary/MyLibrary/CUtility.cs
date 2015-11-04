using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class CUtility
    {

        public static double GetValue(string prompt, double min, double max)
        {
            double input = 0.0;
            bool success = false;

            do
            {
                Console.Write(prompt);
                success = double.TryParse(Console.ReadLine(), out input);

                if (success == false)
                {
                    Console.WriteLine("You entered an invalid number.");
                }


                if ((input < min) || (input > max))
                {
                    Console.WriteLine("You have entered an out of range value.");
                    success = false;
                }

            } while (!success);
            return input;
        }



        public static int GetValue(string prompt, int min, int max)
        {
            int input = 0;
            bool success = false;

            do
            {
                Console.Write(prompt);
                success = int.TryParse(Console.ReadLine(), out input);

                if (success == false)
                {
                    Console.WriteLine("You entered an invalid number.");
                }
                
                if ((input < min) || (input > max))
                {
                    Console.WriteLine("You have entered an out of range value.");
                    success = false;
                }

            } while (!success);
            return input;
        }

        public static void Pause(string prompt)
        {
            Console.Write(prompt);
            Console.ReadKey();
            Console.WriteLine();

        }
    }
}
