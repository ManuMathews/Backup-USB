using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ManuMathews_Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables:
            bool trueOrFalse = false;     
            string userEntry;   
            ulong intForTesting; 
            ulong tracker = 0; // keeps track of 1's in number

            Console.WriteLine("Parity\n");

            Console.WriteLine("Enter an integer value: ");

            do
            {
                userEntry = Console.ReadLine();
                trueOrFalse = ulong.TryParse(userEntry, out intForTesting);

                if(intForTesting == 0)
                {
                    trueOrFalse = false;
                    Console.WriteLine(" Invalid entry. Please enter an integer value above 0 for evaluation: ");
                }

                if (trueOrFalse == false)
                {
                    Console.WriteLine(" Invalid entry. Please enter an integer value above 0 for evaluation: ");
                }

            } while (trueOrFalse == false);

            

            // Checking bits to find number of 1's in number.
            for (ulong i = (ulong)Math.Pow(2, 63) ; i > 0; i = i / 2)
            {
                if ((intForTesting & i) != 0) 
                {
                    tracker++;
                }

                if ((intForTesting & i) == 0)
                {
                    //so far nothing needed here
                }
            }


            // Checking for remainder to decide if "tracker" is odd or even : Tracker is the number of 1's in users integer.
            if(tracker%2 != 0)
            {
                Console.WriteLine("\nOdd");
            }
            if(tracker%2 == 0 && tracker != 0)
            {
                Console.WriteLine("\nEven");
            }

            Console.Write("\n\nPress Enter to exit:");
            Console.ReadLine();
            
        }
    }
}
