using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManuMathewsMethodLibrary;

namespace CMPE1300ManuMathewsAssignment13
{
    class LibraryTesting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Library!\n");

            MyMethods.Pause();
        }

        private static int GetValue(string promptText, int min, int max, string invalidTooHigh, string invalidTooLow, string invalidValueType)
        {
            int input = 0;
            bool success = false;

            do
            {

                Console.Write(promptText);
                success = int.TryParse(Console.ReadLine(), out input);

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

        private static float GetValue(string promptText, float min, float max, string invalidTooHigh, string invalidTooLow, string invalidValueType)
        {
            float input = 0;
            bool success = false;

            do
            {

                Console.Write(promptText);
                success = float.TryParse(Console.ReadLine(), out input);

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

        private static decimal GetValue(string promptText, decimal min, decimal max, string invalidTooHigh, string invalidTooLow, string invalidValueType)
        {
            decimal input = 0;
            bool success = false;

            do
            {

                Console.Write(promptText);
                success = decimal.TryParse(Console.ReadLine(), out input);

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

        private static double GetValue(string promptText, double min, double max, string invalidTooHigh, string invalidTooLow, string invalidValueType)
        {
            double input = 0.0;
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
    }
}
