using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsAssignment07
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBits = 0;
            string inputBytes;
            int bitsPerSeconds = 0;
            string inputRate;
            bool success;

            int bitsPerMilliseconds = 0;
            int inDays = 0;
            int hours = 0;
            int minutes = 0;
            int seconds = 0;
            int milliseconds = 0;
            int timeInMilliseconds = 0;
            int inDaysRemainderInMilliseconds = 0;
            int inHoursRemainderInMilliseconds = 0;
            int inMinutesRemainderInMilliseconds= 0;
            int inSecondsRemainderInMilliseconds = 0;


            Console.WriteLine("Welcome to the FileTransfer Time Estimator\n\n");

            do
            {

                Console.Write("Please enter the number of bytes you wish to transfer:\t");
                inputBytes = Console.ReadLine();

                success = int.TryParse(inputBytes, out numberOfBits);
              

            } while (!success);

            numberOfBits = numberOfBits * 8;
            
            Console.WriteLine("\n");

            do
            {
                Console.Write("Please enter the transfer rate (bits per second):\t");
                inputRate = Console.ReadLine();

                success = int.TryParse(inputRate, out bitsPerSeconds);
                

            
            } while (!success);
            //  changing rate from bits/seconds to bits/milliseconds
            bitsPerMilliseconds = bitsPerSeconds * 1000;
            timeInMilliseconds = numberOfBits / bitsPerMilliseconds;


            
           
            
            //  Calculations                     //double check calculations.

            inDays = timeInMilliseconds / 86400000;

            inDaysRemainderInMilliseconds = timeInMilliseconds % 86400000;

            hours = inDaysRemainderInMilliseconds / 3600000;

            inHoursRemainderInMilliseconds = inDaysRemainderInMilliseconds % 3600000;

            minutes = inHoursRemainderInMilliseconds / 60000;
            
            inMinutesRemainderInMilliseconds = inHoursRemainderInMilliseconds % 60000;
            
            seconds = inMinutesRemainderInMilliseconds / 1000;
            
            inSecondsRemainderInMilliseconds = inMinutesRemainderInMilliseconds % 1000;

            milliseconds = inSecondsRemainderInMilliseconds;
            
            
            
            
            Console.WriteLine("Your file transfer will take approximately:");

            Console.WriteLine("\n\t{0} days, {1} hours, {2} minutes, {3} seconds and {4} milliseconds", inDays, hours, minutes, seconds, milliseconds);








            Console.WriteLine("\n\nPress any key to exit...");
            Console.ReadKey();

        }
    }
}
