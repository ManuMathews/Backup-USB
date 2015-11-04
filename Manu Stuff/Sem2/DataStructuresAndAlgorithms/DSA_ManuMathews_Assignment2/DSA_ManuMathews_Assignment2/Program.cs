using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ManuMathews_Assignment2
{
    class Program
    {
        /**************************************
        *   MANU MATHEWS
        *   CMPE 1700
        *   Assignment 2
        *
        *   Asking the user for a single line that contains a number and a line that we have to repeat any number of times that the user requires.
        *   
        **********************************************************************************************************/



        static void Main(string[] args)
        {   
            string userEntry;               // for storing users entries
            int reptNumb = 0;               // for storing the number of times the statement will repeat
            bool trueOrFalse = false;       // to decide if the user entry is valid
            string[] splitUserEntry = { "random stuff" }; // for splitting userEntry into two parts
            int i = 0;                      // keeping count
            string userEnteredNumber;       // from userEntry


            Console.WriteLine("Please enter the line you would like to repeat, \nand the number of times you would like it to repeat, \nin the format given below: ");
            Console.WriteLine("Please separate the number and the line with this symbol: *");
            Console.WriteLine("'##' * 'Line you would like to repeat.' ");



            //recieving users response; checking for potential errors.
            do
            {
                Array.Clear(splitUserEntry, 0, splitUserEntry.Length);
                Console.WriteLine();
                userEntry = Console.ReadLine();
                splitUserEntry = userEntry.Split('*');
                userEnteredNumber = splitUserEntry[0].Trim();
                trueOrFalse = int.TryParse(userEnteredNumber, out reptNumb);

                if (splitUserEntry == null ||/* splitUserEntry[1] == null ||*/ splitUserEntry.Length < 0)
                {
                    trueOrFalse = false;
                }


                if (trueOrFalse == false)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("You used the wrong format!");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Please use the format given above: ");
                    Console.ForegroundColor = ConsoleColor.White;
                }


            } while (trueOrFalse == false);


            //typing users entry out multiple times.
            do
            {
                i++;
                Console.WriteLine(splitUserEntry[1].Trim());
                
            } while (i < reptNumb);


            Console.Write("Press any key to exit the program...");
            Console.ReadKey();
        }


        

    }
}
