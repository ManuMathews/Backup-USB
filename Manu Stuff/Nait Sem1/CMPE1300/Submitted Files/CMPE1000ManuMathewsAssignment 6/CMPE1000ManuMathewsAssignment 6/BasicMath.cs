using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1000ManuMathewsAssignment_6
{
    class BasicMath
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Basic Arithmetic Order of Operations\n");

            //Section A_

            // Section A question 1
            int AvalueOf1 = 0;
            AvalueOf1 = 16 / 4 * 32 - (6 / 3);
            // Section A question 2
            int Avalueof2 = 0;
            Avalueof2 = (9 / 3 - 20 * 6 + (14 / 2)) / (25 / 5 * 3 - 4 * (35 / 7)) / 11;

            Console.WriteLine("Section A Results:\tQ1){0}\t\tQ2) {1}", AvalueOf1, Avalueof2);

            //End of Section A_

            //Section B_

            //Question 1
            int S = 0;
            int L = 5;
            int W = 8;
            int H = 12;

            S = L * W + (W * H) + (L * H * 2) + (L * W) + (W * H);
            
            //Question 2
            int G = 0;
            L = 40;
            H = 5;
            int I = 8;
            int J = 2;
            int K = -3;
            int R = 4;
            int M = 10;
            int N = 4;

            G = L / H + (I / J) * K + R / M - N;

            Console.WriteLine("\nSection B Results:\tQ1){0}\t\tQ2){1}", S, G);

            //End of Section B

            //Section C

            R = 0;
            int A = 10;
            int B = -5;
            int C = 6;
            int D = 4;
           
            R = C - D;
            R = R * B;
            R = R + 1;
            R = R * A;

            Console.WriteLine("\nSection C Results:\tQ1){0}", R);


            Console.WriteLine("\nPress any key to exit..._");
            Console.ReadKey();
        }
    }
}
