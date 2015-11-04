using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE1300ManuMathewsAssignment11
{
    class CollisionDetection
    {
        static void Main(string[] args)
        {
            Random randomNumber = new Random();
            bool success = false;
            
            

          

                Console.Write("Press the spacebar to evaluate a pair of circles.");

                do
                {
                    ConsoleKeyInfo entry = Console.ReadKey();
                    if (entry.Key == ConsoleKey.Spacebar)
                    {
                        success = true;
                        
                    }

                    if (success)
                    {
                        int x1 = randomNumber.Next(200, 600);
                        int y1 = randomNumber.Next(200, 400);
                        int x2 = randomNumber.Next(200, 600);
                        int y2 = randomNumber.Next(200, 400);
                        int radius1 = randomNumber.Next(25, 201);
                        int radius2 = randomNumber.Next(25, 201);
                        //imagining a triangle with: a == (distance between x1 and x2); b == (distance between y1 and y2); and c == (distance between centers of the circles).
                        int a = x2 - x1;
                        int b = y2 - y1;
                        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));




                        if ((radius1 + radius2)/2 >= c)
                        {
                            CDrawer canvas = new CDrawer(800, 600);
                            canvas.AddCenteredEllipse(x1, y1, radius1, radius1, Color.Red);
                            canvas.AddCenteredEllipse(x2, y2, radius2, radius2, Color.Red);
                        }

                        if (radius1 + radius2 < c)
                        {
                            CDrawer canvas2 = new CDrawer(800, 600);
                            canvas2.AddCenteredEllipse(x1, y1, radius1, radius1, Color.Blue);
                            canvas2.AddCenteredEllipse(x2, y2, radius2, radius2, Color.YellowGreen);
                        }

                        Console.Write("");

                    }


                    ConsoleKeyInfo entryb = Console.ReadKey();
                    if (entryb.Key == ConsoleKey.Spacebar)
                    {
                        success = false;
                    }

                    else
                    {
                        success = true;
                    }



                } while (!success);

            Console.ReadKey();
        }
    }
}



