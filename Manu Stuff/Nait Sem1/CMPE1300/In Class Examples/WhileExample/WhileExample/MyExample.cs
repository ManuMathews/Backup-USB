using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;


namespace WhileExample
{
    class MyExample
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //ConsoleKeyInfo keyPressed;



            //while(x < 10)
            //{
              //  Console.WriteLine(x);
                //++x;
            //}

            
            //keyPressed = Console.ReadKey();

            //Console.WriteLine(keyPressed.Key);

            //Console.ReadKey();


            /// end of that part
            //start of new part



            CDrawer canvas = new CDrawer(800,600);

            Console.WriteLine("Draw Something");

            canvas.AddCenteredEllipse(200, 100, 100, 100, Color.Red, 2, Color.White);

            canvas.AddLine(50, 50, 400, 500, Color.Green, 5);

            canvas.AddRectangle(400, 300, 100, 50, Color.Purple, 2, Color.White);
            canvas.AddText("meat", 24, Color.Magenta);
            canvas.AddText("Bacon", 36, 300, 150, 250, 50, Color.Lime);
            
            Console.ReadKey();


            //to have random color:-    "RandColor.GetColor()"


        }
    }
}
