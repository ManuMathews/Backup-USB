using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManuLab2Practice2
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius = 0.00;
            double height = 0.00;
            double volume;

            radius = GetValue("Enter the radius (meters) of the tank: ", (double)0, (double)100, "Input is too high", "Input is too low", "The entry is invalid");
            height = GetValue("Enter the height (meters) of the tank: ", (double)0, (double)100, "Input is too high", "Input is too low", "The entry is invalid");

            volume = Volume(radius, height);



        }

        private static double GetValue(string promptText, double min, double max, string invalidTooHigh, string invalidTooLow, string invalidValueType)
        {
            double input = 0;
            bool success = false;

            do
            {

                Console.Write(promptText);
                success = double.TryParse(Console.ReadLine(), out input);

                if (!success)
                {
                    Console.WriteLine(invalidValueType);
                }


                if (input < min)
                {
                    Console.WriteLine(invalidTooLow);
                    success = false;
                }

                if (input > max)
                {
                    Console.WriteLine(invalidTooHigh);
                }

            } while (!success);
            return input;
        }

        public static double Volume(double radius, double height)
        {
            double answer = Math.PI * radius * radius * height;


            return answer;
        }

        public void Display(double radius, double volume, double height)
        {
            Console.WriteLine("A tank radius " + radius + " meters and height " + height + " meters has a volume of " + volume + " cubic meters.");
        }

    }
}
