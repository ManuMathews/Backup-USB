using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;

namespace CMPE1300ManuMathewsLab03
{
    class EtchASketch
    {

        static void Main(string[] args)
        {
            CDrawer s_Draw = new CDrawer();
            int[] movesSaved = new int[500000];
            ConsoleKeyInfo MenuChoice;
            bool success = false;
            int xCoordinate = 0;
            int yCoordinate = 0;


            do
            {
                Console.WriteLine("\t\t   Etch");
                Console.WriteLine("\nPlease select from the menu below:\n");
                Console.WriteLine("\nd. Start Drawing.    \ns.Set Starting Point.     \nc. Clear Display       \np. Play Back Moves.     \nx. Exit Program.");
                MenuChoice = Console.ReadKey();
                if(MenuChoice.Key == ConsoleKey.D)
                {
                    movesSaved = Draw(xCoordinate, yCoordinate, s_Draw);
                }

                if(MenuChoice.Key == ConsoleKey.S)
                {
                    xCoordinate = GetValue(801, 0, "Enter the x-coordinate of the starting point.", "The x value should be between 1 and 800.", "Please enter a valid integer for the x-coordinate.");
                    yCoordinate = GetValue(601, 0, "Enter the y-coordinate of the starting point.", "The x value should be between 1 and 600.", "Please enter a valid integer for the y-coordinate.");
                }

                if(MenuChoice.Key == ConsoleKey.C)
                {
                    s_Draw.BBColour = Color.Black; // This will set all pixels in the CDrawer window to the specified color.
                }

                if(MenuChoice.Key == ConsoleKey.P)
                {
                    PlayBack(movesSaved, xCoordinate, yCoordinate, s_Draw);
                }
                if(MenuChoice.Key == ConsoleKey.X)
                {
                    success = true;
                }

 

            } while (!success);



            Console.ReadKey();
        }
        //         END OF MAIN                 END OF MAIN               END OF MAIN

        static int[] Draw(int xCoordinate, int yCoordinate, CDrawer s_Draw)
        {
            int[] arrayOfXValues = new int[500000];
            int[] arrayOfYValues = new int[500000];
            int v = 0;
            int[] colorAtMove_PlaceDesignator = new int[500000];
            int xPoint = xCoordinate;
            int ypoint = yCoordinate;
            Color color = Color.Green;
            Color r = Color.Red;
            Color g = Color.Green;
            Color b = Color.Blue;
            bool success = false;
            ConsoleKeyInfo lineDirection;
            

            
            do
            {
                if (color == Color.Red)
                {
                    lineDirection = Console.ReadKey();
                    if (lineDirection.Key == ConsoleKey.UpArrow)
                    {
                        yCoordinate += 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, r);
                        colorAtMove_PlaceDesignator[v] = 1;
                        v += 1;
                    }

                    if (lineDirection.Key == ConsoleKey.DownArrow)
                    {
                        yCoordinate -= 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, r);
                        colorAtMove_PlaceDesignator[v] = 2;
                        v += 1;
                    }

                    if (lineDirection.Key == ConsoleKey.LeftArrow)
                    {
                        xCoordinate -= 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, r);
                        colorAtMove_PlaceDesignator[v] = 3;
                        v += 1;
                    }

                    if (lineDirection.Key == ConsoleKey.RightArrow)
                    {
                        xCoordinate += 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, r);
                        colorAtMove_PlaceDesignator[v] = 4;
                        v += 1;
                    }
                }


                if (color == Color.Green)
                {
                    lineDirection = Console.ReadKey();
                    if (lineDirection.Key == ConsoleKey.UpArrow)
                    {
                        yCoordinate += 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, g);
                        colorAtMove_PlaceDesignator[v] = 5;
                        v += 1;
                    }
                    if (lineDirection.Key == ConsoleKey.DownArrow)
                    {
                        yCoordinate -= 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, g);
                        colorAtMove_PlaceDesignator[v] = 6;
                        v += 1;
                    }
                    if (lineDirection.Key == ConsoleKey.LeftArrow)
                    {
                        xCoordinate -= 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, g);
                        colorAtMove_PlaceDesignator[v] = 7;
                        v += 1;
                    }
                    if (lineDirection.Key == ConsoleKey.RightArrow)
                    {
                        xCoordinate += 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, g);
                        colorAtMove_PlaceDesignator[v] = 8;
                        v += 1;
                    }
                }


                if (color == Color.Blue)
                {
                    lineDirection = Console.ReadKey();
                    if (lineDirection.Key == ConsoleKey.UpArrow)
                    {
                        yCoordinate += 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, b);
                        colorAtMove_PlaceDesignator[v] = 9;
                        v += 1;
                    }
                    if (lineDirection.Key == ConsoleKey.DownArrow)
                    {
                        yCoordinate -= 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, b);
                        colorAtMove_PlaceDesignator[v] = 10;
                        v += 1;
                    }
                    if (lineDirection.Key == ConsoleKey.LeftArrow)
                    {
                        xCoordinate -= 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, b);
                        colorAtMove_PlaceDesignator[v] = 11;
                        v += 1;
                    }
                    if (lineDirection.Key == ConsoleKey.RightArrow)
                    {
                        xCoordinate += 1;
                        s_Draw.SetBBPixel(xPoint, ypoint, b);
                        colorAtMove_PlaceDesignator[v] = 12;
                        v += 1;
                    }


                }
            } while (!success);
            return arrayOfXValues;

        }// draws the lines and returns array of x values
        
        //         END OF DRAW                 END OF DRAW               END OF DRAW

   

        static void PlayBack(int[] arrayOfMoves, int xCoordinate, int yCoordinate, CDrawer s_Draw)
        {
            Color r = Color.Red;
            Color g = Color.Green;
            Color b = Color.Blue;

            s_Draw.SetBBPixel(xCoordinate, yCoordinate, b);
            foreach (int i in arrayOfMoves)
            {
                if (arrayOfMoves[i] == 1)
                {
                    
                    yCoordinate += 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, r);
                }

                if (arrayOfMoves[i] == 2)
                {

                    yCoordinate -= 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, r);
                }

                if (arrayOfMoves[i] == 3)
                {

                    xCoordinate -= 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, r);
                }

                if (arrayOfMoves[i] == 4)
                {

                    xCoordinate += 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, r);
                }

                if (arrayOfMoves[i] == 5)
                {

                    yCoordinate += 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, g);
                }

                if (arrayOfMoves[i] == 6)
                {

                    yCoordinate -= 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, g);
                }

                if (arrayOfMoves[i] == 7)
                {

                    xCoordinate -= 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, g);
                }

                if (arrayOfMoves[i] == 8)
                {

                    xCoordinate += 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, g);
                }

                if (arrayOfMoves[i] == 9)
                {

                    yCoordinate += 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, b);
                }

                if (arrayOfMoves[i] == 10)
                {

                    yCoordinate -= 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, b);
                }

                if (arrayOfMoves[i] == 11)
                {

                    xCoordinate -= 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, b);
                }

                if (arrayOfMoves[i] == 12)
                {

                    xCoordinate += 1;
                    s_Draw.SetBBPixel(xCoordinate, yCoordinate, b);
                }




            //end of array draw foreach____
            }

        }

        static int GetValue(int max, int min, string requirementStatement, string outOfRange, string errorMessage)
        {
            int value;
            bool success = false;

            do
            {
                Console.Write(requirementStatement);
                success = int.TryParse(Console.ReadLine(), out value);
                if(!success)
                {
                    Console.WriteLine(errorMessage);
                    success = false;
                }
                if(value < min || value > max)
                {
                    Console.WriteLine(outOfRange);
                    success = false;
                }
            }while(!success);
            return value;
        }




    }
}
