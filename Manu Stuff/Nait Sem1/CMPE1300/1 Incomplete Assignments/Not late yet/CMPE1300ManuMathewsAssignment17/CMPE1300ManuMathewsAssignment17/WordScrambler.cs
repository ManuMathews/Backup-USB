using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsAssignment17
{
    class WordScrambler
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                string line;
                Console.WriteLine("Welcome to Word Scrambler!\n\n");

                Console.WriteLine("Enter a phrase between 10 and 60 characters long:");

                Console.Write("\n\t");
                line = Console.ReadLine();








                Console.WriteLine("Press any key to scramble another word or the 'Esc' key to exit...");
                ConsoleKeyInfo keyPress;
                keyPress = Console.ReadKey();
                if (keyPress.Key == ConsoleKey.Escape)
                {
                    exit = true;
                }
                if (keyPress.Key != ConsoleKey.Escape)
                {
                    exit = false;
                }
            } while (!exit);
        }


    }
}
