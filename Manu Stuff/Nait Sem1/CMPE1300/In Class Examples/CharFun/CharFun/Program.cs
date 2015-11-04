using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharFun
{
    class Program
    {
        static void Main(string[] args)
        {
            //char[] ch = new char [10];

           //ch[0] = (char)Console.Read();

           // switch(ch)
           // {
           //     case 'a':
             //       Console.WriteLine("a was pressed");
             //       break;
//
            //    case 'b' :
           //         Console.WriteLine("b was pressed");
            //        break;

           //     default:
           //         Console.WriteLine("A wrong characther was input...");
            //   }

            //string stuff = "JD Silver";

            ///foreach(char ch in stuff)
            ///{
              ///  Console.WriteLine(ch);
            ///}


            string stuff = "JD Silver";

            char[] array = stuff.ToCharArray(); ;

            for (int i = 0; i < array.Length; i++)
			{
                array[i] = (char)(array[i] + 1);
                Console.WriteLine(array[i]);
			}










            Console.ReadKey();
        }
    }
}
