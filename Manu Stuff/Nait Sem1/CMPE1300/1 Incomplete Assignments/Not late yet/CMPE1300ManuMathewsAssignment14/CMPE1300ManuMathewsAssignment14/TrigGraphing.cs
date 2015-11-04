using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE1300ManuMathewsAssignment14
{
    class TrigGraphing
    {
        const int unitValue = 100;  // 100pixels for unit x and y value
        const int unitValue2 = 50;  // 50pixels for unit x and y value
        const int unitValue3 = 30;  // 30pixels for unit x and y value
        const int unitValue4 = 10;  // 30pixels for unit x and y value

        static void Main(string[] args)
        {

            //make a canvas for graph
            CDrawer canvas = new CDrawer();
            //  y = Amplitude.sin(AngularFrequency.x + PhaseAngle) + VerticalOffset
            // a = Amplitude || f = AngularFrequency || p = Phase angle || v = VerticalOffset
            bool success = false;
            bool success2 = false;
            double a = 0.00;
            double f = 0.00;
            double p = 0.00;
            double v = 0.00;
            ConsoleKeyInfo userChoice;
            Grid(canvas);
            do
            {
                do
                {
                    userChoice = GetUserChoice("Action:  ");
                    Console.WriteLine(userChoice);
                    






                } while (!success);
                Console.Clear();
            } while (!success2);

            Console.ReadKey();
        }

      
        static ConsoleKeyInfo GetUserChoice(string quiry)
        {
            bool success = false;
            do
            {
                Console.WriteLine(quiry);
                ConsoleKeyInfo userChoice;
                userChoice = Console.ReadKey();

                return userChoice;





            } while (!success);
            









            return userChoice;
        }

        static double DegreeToRadians(int degrees)
        {
            double radians = (degrees * 2 * Math.PI) / 360;
            return radians;
        }

        static void GraphSinusoid(CDrawer cdBase, double amplitude = 1, double angularFrequency = 1, double phaseAngle = 0, double verticalOffset =0)
        {

        }

        static void GraphTangent(CDrawer cdBase, double amplitude = 1, double angularFrequency = 1, double phaseAngle = 0, double verticalOffset = 0)
        {

        }

        static void Grid(CDrawer canvas)
        {
            for (int x = 0; x < 800; x++)
            {
                canvas.SetBBPixel(x, 300, Color.Red);

                //drawing the x ticks
                if ((x % unitValue) == 0)
                {

                    for (int y = 294; y < 306; ++y)
                        canvas.SetBBPixel(x, y, Color.Red);

                }



                if ((x % unitValue2) == 0)
                {

                    for (int y = 297; y < 304; ++y)
                        canvas.SetBBPixel(x, y, Color.Red);

                }

                if ((x % unitValue4) == 0)
                {

                    for (int y = 299; y < 302; ++y)
                        canvas.SetBBPixel(x, y, Color.Red);

                }
            }

            for (int y = 0; y < 600; y++)
            {
                canvas.SetBBPixel(400, y, Color.Red);

                //drawing y ticks
                if ((y % unitValue3) == 0)
                {

                    for (int x = 395; x < 405; ++x)
                        canvas.SetBBPixel(x, y, Color.Red);
                }

            }



        }
    }
}
