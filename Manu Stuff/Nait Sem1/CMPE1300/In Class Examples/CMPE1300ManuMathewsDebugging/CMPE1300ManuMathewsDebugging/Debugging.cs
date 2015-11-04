using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsDebugging
{
    class Debugging
    {
        static void Main(string[] args)
        {
            double dPI = 0.0;
            double dTerm = 0.0;
            int iDenominator = 0;
            for (int i = 0; i <= 200000000; i++)
            {
                iDenominator = (i % 2 == 0 ? 1 : -1) * ((i * 2) + 1);
                dTerm = 4.0 / iDenominator;
                dPI = dPI + dTerm;
                if (i % 1000 == 0) //Check every 1000 iterations
                    Console.WriteLine("At i = {0}, PI = {1}", i, dPI);
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
