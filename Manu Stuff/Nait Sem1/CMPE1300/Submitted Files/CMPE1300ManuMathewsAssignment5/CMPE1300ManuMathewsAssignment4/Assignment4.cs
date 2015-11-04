using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsAssignment4
{
    class Assignment4
    {
        static void Main(string[] args)
        {

            string UserName;
            string NewLine;
            string EncryptedLine;

            //Greeting
            Console.WriteLine("Welcome to Encrypto!");
            // asking for username
            Console.Write("\n\nPlease enter your user name:");
            UserName = Console.ReadLine();

            // turn user name to small letters and take out extra spaces
            UserName = UserName.Trim();
            UserName = UserName.ToLower();

            //ask for line to be encrypted/recieve the text
            Console.Write("\n\n");
            Console.Write("{0}, please type in the phrase you wish to have encrypted:",UserName);
            Console.Write("\n\n\t");
            NewLine = Console.ReadLine();
            NewLine = NewLine.ToLower();
            
            //Substitutions for all alphabets.
            //A B C D E F H I L M N O S T W Y
            //C K G O D T W E N X V F I L U R

            EncryptedLine = NewLine.Replace('c', 'g');
            EncryptedLine = EncryptedLine.Replace('b', 'k');
            EncryptedLine = EncryptedLine.Replace('h', 'w');
            EncryptedLine = EncryptedLine.Replace('m', 'x');
            EncryptedLine = EncryptedLine.Replace('n', 'v');
            EncryptedLine = EncryptedLine.Replace('w', 'u');
            EncryptedLine = EncryptedLine.Replace('y', 'r');
            EncryptedLine = EncryptedLine.Replace('a', 'c');
            EncryptedLine = EncryptedLine.Replace('d', 'o');
            EncryptedLine = EncryptedLine.Replace('e', 'd');
            EncryptedLine = EncryptedLine.Replace('f', 't');
            EncryptedLine = EncryptedLine.Replace('i', 'e');
            EncryptedLine = EncryptedLine.Replace('l', 'n');
            EncryptedLine = EncryptedLine.Replace('o', 'f');
            EncryptedLine = EncryptedLine.Replace('s', 'i');
            EncryptedLine = EncryptedLine.Replace('t', 'l');

                                         


            //Change NewLine and Encryption into capital letters
            NewLine = NewLine.ToUpper();
            EncryptedLine = EncryptedLine.ToUpper();

            //providde encrypted version in capital letters
            Console.Write("\n\n{0}, the encrypted version of the phrase...",UserName);
            Console.Write("\n\n\t{0}", NewLine);
            Console.Write("\n\nis...");

            Console.Write("\n\n\t{0}", EncryptedLine);
            

            Console.Write("\n\n\n\nThank you for using Encrypto!   Come back soon!");
            Console.Write("\n\n\n\nPress any key to exit: ");
            Console.ReadKey();
        }
    }
}
