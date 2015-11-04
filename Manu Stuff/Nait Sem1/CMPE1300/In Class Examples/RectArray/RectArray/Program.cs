using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] array = new int[3, 4];

            for(int row = 0; row < 3; ++row)
            {
                for (int col = 0; col < 4; col++)
			    {
		        	 array[row, col] = rand.Next(0, 101);

			    }
            }
            for (int row = 0; row < 3; row++)
			{
			    for(int col = 0; col < 4; ++col)
                {
                    Console.Write("{0:N3}   ", array[row, col]);   
                }
                Console.WriteLine();
                
			}
            Console.WriteLine("Rows: {0}", array.GetLength(0));
            Console.WriteLine("Columens: {0}", array.GetLength(1));

            Console.ReadLine();
        }
    }
}
