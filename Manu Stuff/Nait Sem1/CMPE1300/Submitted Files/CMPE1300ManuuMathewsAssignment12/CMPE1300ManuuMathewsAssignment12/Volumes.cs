using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuuMathewsAssignment12
{
    class Volumes
    {
        static void Main(string[] args)
        {
            

            bool success = false;
            string userInput;
            



            Console.WriteLine("Welcome to the Volume Calculator!");
            Console.WriteLine("\nThis program will calculate the volume of the user's chosen object.\n\n");


            do
            {
                Console.WriteLine("Choose one of the following: \nS - Sphere \nC - Cylinder \nB -Box");
                Console.Write("Your choice:  ");
                userInput = Console.ReadLine();
                userInput = userInput.Trim();
                userInput = userInput.ToLower();
                Console.WriteLine("");
                if (userInput == "s")
                {

                    double sphereVolume = CalculateSphereVolume();
                    Console.WriteLine("\nThe volume of the sphere is {0:###.###} cubic units.", sphereVolume);
                    success = true;
                }

                if(userInput == "c")
                {

                    double cylinderVolume = CalculateCylinderVolume();
                    Console.WriteLine("\nThe volume of the cylinder is {0:###.###} cubic units.", cylinderVolume);
                    success = true;
                }

                if(userInput == "b")
                {
                    double boxVolume = CalculateBoxVolume();
                    Console.WriteLine("\nThe volume of the box is {0:###.###} cubic units.", boxVolume);
                    success = true;
                }

                if (!success)
                {

                    Console.WriteLine("\nThat is not a valid choice\n");
                }


                if (success)
                {
                    Console.WriteLine("\nPress 'X' to exit or any other key to perform another calculation...");
                    userInput = Console.ReadLine();
                    userInput = userInput.Trim();
                    userInput = userInput.ToLower();

                    if (userInput == "x")
                    {
                        success = true;
                    }
                    if (userInput != "x")
                    {
                        success = false;
                    }
                }

            } while (!success);


        }






        private static double GetValue(string promptText, double min, double max, string invalidTooHigh, string invalidTooLow, string invalidValueType)
        {
            double input = 0.0;
            bool success = false;

            do
            {
                
                Console.Write(promptText);
                success = double.TryParse(Console.ReadLine(), out input);

                if (!success)
                {
                    Console.WriteLine(invalidValueType);
                }


                if (input < min)
                {
                    Console.WriteLine(invalidTooLow);
                    success = false;
                }

                if(input > max)
                {
                    Console.WriteLine(invalidTooHigh);
                }

            } while (!success);
            return input;
        }

        static double CalculateSphereVolume()
        {

            double sphereRadius = GetValue("Enter the radius for the sphere:  ", 1, 100, "Sphere radius must be 100 or less!", "Sphere radius must be 1 or more!", "You must enter a valid number!");
           

            double answer = (Math.PI * sphereRadius * sphereRadius * sphereRadius * 4) / 3;

            return answer;
            
            
        }

        private static double CalculateCylinderVolume()
        {

            double cylinderRadius = GetValue("Enter the radius for the end of the cylinder:  ", 1, 100, "Cylinder radius values may not be less than 1 or greater than 100!", "Cylinder radius values may not be less than 1 or greater than 100!", "Cylinder radius values must be numbers!");
            Console.WriteLine(" ");
            double cylinderHeight = GetValue("Enter the height for the cylinder:  ", 1, 100, "Cylinder height values may not be less than 1 or greater than 100!", "Cylinder height values may not be less than 1 or greater than 100!", "Cylinder height values must be numbers!");
            Console.WriteLine(" ");
            double answer = (Math.PI * cylinderRadius * cylinderRadius * cylinderHeight);                                    return answer;        }

        private static double CalculateBoxVolume()
        {
            double boxHeight = GetValue("Enter the height for the box:  ", 0, 100000, "You must enter a valid number between 0 and 100000!", "Box height must be 1 or more!", "You must enter a valid number!");
            double boxWidth = GetValue("Enter the width for the box:  ", 0, 100000, "You must enter a valid number between 0 and 100000!", "You must enter a valid number between 0 and 100000!", "You must enter a valid number!");
            double boxLength = GetValue("Enter the length for the box:  ", 0, 100000, "You must enter a valid number between 0 and 100000!", "You must enter a valid number between 0 and 100000!", "You must enter a valid number!");

            double boxVolume = boxHeight * boxWidth * boxLength;

            double answer = boxVolume;
            return answer;
        }
        
        
        
        
        
        
    }
}
