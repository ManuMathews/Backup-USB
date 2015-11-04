//***********************************************************************************
//Program: AtomicCannon.cs
//Description: A program that simulates a 2 dimentional cannon launch with randomly 
//generated targets. The user can attempt to neutralize a target by adjusting the 
//firing angle and muzzle velocity.
//Lab: 02
//Date: 11/25/2014
//Author: Manu Mathews
//Course: CMPE1300
//Class: CNTA02
//Instructor: JD Silver
//***********************************************************************************


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsLab02
{
    class AtomicCannon
    {
        static void Main(string[] args)
        {
            
            
            bool success = false;                                                                       //Boolean value 1
            bool success2 = false;                                                                      //Boolean value 2
            bool success3 = false;                                                                      //Boolean value 3
            bool success4 = false;                                                                      //Boolean value 4
            double velocity = 0.00;                                                                     //Creating a double value to store muzzle velocity
            double angle = 0;                                                                           //Creating a double value to store firing angle
            Random randomNumber = new Random();                                                         //Creating random number
            int numberOfRounds = 0;                                                                     //Integer to store the number of trys by the  user
            ConsoleKeyInfo userSelection;                                                               //Key info to store key input

            
                do                                                                                      //do-while loop to start a new challenge with a new target
                {
                    int randomTargetDistance = randomNumber.Next(500, 2001);                            //creating a new target
                    numberOfRounds = 5;                                                                 

                    do                                                                                  //do-while loop that is activated when the user fires the cannon
                    {
                        do                                                                              //do-while loop that is activated when the user changes the velocity or angle
                        {
                            success = false;                                                            //making sure all the boolean values are false at the beginning of the program
                            success2 = false;                                                           
                            success3 = false;
                            success4 = false;
                            Intro(randomTargetDistance, velocity, angle, numberOfRounds);               //using the method that provides the user with all the basic information about the program
                            DisplayActions();                                                           //continuation to the previous method
                            userSelection = UserKeyInput("Please make a selection: ");                  //asking the user for their input on which option they would like to select

                            if (userSelection.Key == ConsoleKey.V)                                      //if statement for the user input being v
                            {
                                                                                                        //redirecting to the DoubleInput method to get velocity from user
                                velocity = DoubleInput("\nEnter muzzle velocity: ", "The value entered is invalid.", 5, 501, "Velocity should be 5 or more.", "Velocity should be 500 or less");
                                success = false;                                                        //making sure that success is false so the program will refresh the page with the same target


                            }

                            if (userSelection.Key == ConsoleKey.A)                                      //if statement if the user input is a
                            {
                                                                                                        //redirecting to DoubleInput to get the firing angle
                                angle = DoubleInput("\nEnter the firing angle: ", "The value entered is invalid", 5, 81, "Firing angle should be above 5 degrees.", "Firing angle should be 80 degrees or under.");
                                success = false;                                                        //making sure that success is false so the program will refresh the page


                            }

                            if (userSelection.Key == ConsoleKey.F)                                      //if statement for if the user input is f
                            {


                                if (angle == 0 || velocity == 0)                                        //if statement if either the velocity or the firing angle is zero
                                {
                                                                                                        //letting the user know that the program can only go forward with a valid velocity and firing angle
                                    Console.WriteLine("\nYou cannot fire the gun if either the angle or velocity is zero");
                                    Console.ReadKey();                                                  //Pausing the screen till there is a key input so the user can view the message
                                    success = false;                                                    //making success false so the console will refresh everything in the screen
                                    success4 = false;                                                   //making success4 false so the program will refresh the page without changing any of the values
                                }

                                if(Calculation(angle, randomTargetDistance, velocity) == true)          //if statement if the method Calculation returns true
                                {
                                    success = true;                                                     //making success true so that the program will restart

                                }



                                if (success)                                                            //if statement if success is true
                                {
                                    success3 = Calculation(angle, randomTargetDistance, velocity);      //making the bool value of success3 the return value of calculation to check if the target was hit or not
                                }



                                if (success3 == true)                                                   //if statement if success3 is true (they hit the target)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;                         //changing font color to red
                                                                                                        //letting the user know that they hit the target
                                    Console.WriteLine("\nCongratulations! Target has been neutralised.\n");
                                    Console.ReadKey();                                                  //Pausing the game till user enters any key stroke
                                    success4 = true;                                                    //making success4 true so it will pass through the do-while loop dependant on success4

                                }

                                if (!success3)                                                          //if statement if success3 is false (they did not hit the target)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;                         //changing font color to red
                                    Console.WriteLine("\nTarget is still at large!");                   //Letting the user know the target was not hit by the projectile
                                                                                                        //Letting the user know how far the projectile travelled
                                    Console.WriteLine("The projectile travelled {0} meters",CalculationContd(angle, randomTargetDistance, velocity));
                                    Console.ReadKey();                                                  //Pausing the game till user enters any key stroke


                                }
                                success4 = true;                                                        //making success4 true so it will pass through the do-while loop dependant on success4

                            }

                            if (userSelection.Key == ConsoleKey.C)                                      //If statement if the user entered the key c
                            {

                                velocity = FiringComputer(angle, randomTargetDistance);                 //calculating muzzle velocity using the FiringComputer method
                                success = false;                                                        //making success false so it will go past the do while loop dependant on success
                            }

                            if (userSelection.Key == ConsoleKey.N)                                      //If statement if the user entered the key n
                            {
                                success = true;                                                         //making success true to let the program move on from the loop depending on the bool value of success
                                success4 = true;                                                        //making success4 true to let the program move on from the loop depending on the bool value of success4
                            }

                            if (userSelection.Key == ConsoleKey.Q)                                      //If statement if the user entered the key q
                            {
                                success = true;                                                         //making success true to let the program move on from the loop depending on the bool value of success
                                success2 = true;                                                        //making success2 true to let the program move on from the loop depending on the bool value of success2
                                success4 = true;                                                        //making success4 true to let the program move on from the loop depending on the bool value of success4
                            }

                            if (numberOfRounds == 0)                                                    //if statement if the value of numberOfRounds is 0
                            {
                                success2 = true;                                                        //making success2 true to let the program move on from the loop depending on the bool value of success2
                            }

                            Console.Clear();                                                            //Refresing the page while keeping all the values retained till this point
                        } while (!success4);                                                            
                        numberOfRounds = numberOfRounds - 1;                                            //this line will keep track of how many times the user fired the cannon with the same firing distance to ensure that the firing computer becomes active after 5 attempts
                    } while (!success);

                    Console.Clear();                                                                    //clears the entire console before moving on to exit the program or to restart it
                    
                } while (!success2);
                
            



        }

        static ConsoleKeyInfo UserKeyInput(string requirementStatement)                                 //Method UserKeyInput to retrieve the key input from user when required and returns this key input. This method takes in a string from the main method
        {
            Console.Write(requirementStatement);                                                        //displaying the statement supplied by the main program
            ConsoleKeyInfo userKeyInfo = Console.ReadKey();                                             //Recieving and storing the user's key input




            return userKeyInfo;                                                                         //returning the stored key info 
        }
                                                    
                                                                                                        //Method DoubleInput asks the user for a double input with a supplied string, stores it, makess sure it fits within the parameters placed and then returns this double value to the main program
        static double DoubleInput(string requirementStatement, string errorMessage, int min, int max, string belowMinError, string aboveMaxError)
        {
            string input;                                                                               //string input will store the user input as a string before checking to make sure it fits the parameters given
            double doubleInput = 0.000;                                                                 //the double value doubleInput stores the number given by the user after it has gone through inspection
            bool success = false;                                                                       //the boolean value of success will be used in the do while loop to keep the loop going till the user has entered a valid input

            do                                                                                          //do-while loop that will keep repeating till the user inputs a valid number
            {
                Console.Write(requirementStatement);                                                    //displaying the statement that was provided from the main program
                input = Console.ReadLine();                                                             //receiving and storing the user input
                success = double.TryParse(input, out doubleInput);                                      //checking if the input is a doouble value and if it is storing it

                if (doubleInput < min)                                                                  //if statement if the stored double value is smaller than the provided min value
                {
                    success = false;                                                                    //making success false to keep the do-while loop repeating
                    Console.WriteLine(belowMinError);                                                   //displaying the provided error message
                }

                if (doubleInput > max)                                                                  //if statement if the stored double value is more than the provided max value
                {
                    success = false;                                                                    //making success false to keep the do-while loop repeating
                    Console.WriteLine(aboveMaxError);                                                   //displaying the provided error message
                }


                if (!success)
                {
                    Console.WriteLine(errorMessage);                                                    //displaying the provided error message
                    success = false;                                                                    //making success false to keep the do-while loop repeating
                }
            } while (!success);                                                                         

            return doubleInput;                                                                         //returning the stored double value
        }

        static double FiringComputer(double firingAngle, double distance)                               //method FiringComputer calculates the velocity needed to get the projectile to the target with the given angle
        {
            double velocity = 0;                                                                        //the double value velocity will store the calculated velocity
            double radian = (firingAngle * Math.PI) / 180;                                              //changing the angle in fegrees to angle in radians

            velocity = Math.Sqrt((distance * 9.81) / (2 * Math.Sin(radian) * Math.Cos(radian)));        //calculation for finding the velocity
            return velocity;                                                                            //returning calculated velocity
        }

      
                                                                                                        //Method that desplays the introduction
        static void Intro(int randomTargetDistance2, double velocity2, double angle2, int numberOfRounds2) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t\t\tAtomic Cannon Simulator");                                         
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nTarget Distance: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(randomTargetDistance2);
            Console.ForegroundColor = ConsoleColor.White;                                               
            Console.Write("\nGun settings: Velocity = ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("{0:f2} ", velocity2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("m/s, Angle = ");
            Console.ForegroundColor = ConsoleColor.Cyan;                                                
            Console.Write(angle2);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" degrees");
                                                                                                        
            if (velocity2 == 0 || angle2 == 0)
            {
                Console.Write("\nGun status: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not Ready.");
            }

            else
            {                                                                                           
                Console.Write("\nGun status: ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("READY TO FIRE, SIR!");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\nFiring Computer Status: ");
            Console.ForegroundColor = ConsoleColor.Red;

            if (numberOfRounds2 > 1)
            {
                Console.WriteLine("Calculating...");                                                     
            }


            if (numberOfRounds2 == 1)
            {
                Console.WriteLine("CALCULATION COMPLETE, SIR!");

            }
            Console.ForegroundColor = ConsoleColor.White;
        }
                                       
        static void DisplayActions()                                                                     //Continuation for the introduction
        {
            Console.WriteLine("\nSelect action... \nv. Input muzzle velocity. \na. Input firing angle \nf. FIRE! \n\nc. Use firing computer \n\nn.New game \nq. Quit\n\n");
        }

        static bool Calculation(double angle, double distance, double velocity)                          //Method that checks if the velocity and angle provided by the user will take the projectile to the target
        {
            bool success = false;                                                                        // boolea value success
            double distanceTravelled = 0.00;                                                             //this double value stores the distance travelled according to the provided angle and muzzle velocity
            double Radian = (angle * Math.PI) / 180;                                                     // this converts the angle to radians and stores the value
                                                                                                         //calculation to find the distance travelled by the projectile
            distanceTravelled = (2 * Math.Pow(velocity, 2) * Math.Sin(Radian) * Math.Cos(Radian)) / (9.81); 

            Console.WriteLine("The projectile travelled {0} meters", distanceTravelled);                 //displaying the distance travelled by the projectile

            if (distance < distanceTravelled + 10 && distance > distanceTravelled - 10)                  //if statement if the projectile lands within the range of the target
            {
                distance = distanceTravelled;                                                            // making the value of distance (target) equal the value of distanceTravelled (projectile)
            }

            if (distance == distanceTravelled)                                                           //if statement if distance equals distance travelled
            {
                success = true;                                                                          // making success true
            }
            if(distance != distanceTravelled)                                                            // if statement if distance is not in the range of impact
            {
                success = false;                                                                         // making success false
            }



            return success;                                                                              // returning bool value of success to the main program
        }

        static double CalculationContd(double angle, double distance, double velocity)                   //method to calculate and send the distance travelled by the projectile to the main method
        {
            double radian = (angle * Math.PI) / 180;                                                     //converting degrees to radians

                                                                                                         //calculating distance travelled
            double distanceTravelled = (2 * velocity * velocity * Math.Sin(radian) * Math.Cos(radian)) / (9.81);
             
            return distanceTravelled;                                                                    //returning the calculated value
             

        }

    }
}
