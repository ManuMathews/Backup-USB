//***********************************************************************************
//Program: IntegerProblemSolver.cs
//Description: Solves Factorial, Fibonacci Number and Prime Evaluation Integer Problems for the user
//Lab: 1
//Date: September 26, 2014
//Author: Manu Mathews
//Course: CMPE1300
//Class: CNT1D
//Instructor: JD Silver
//***********************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsLab01
{
    class IntegerProblemSolver
    {
        static void Main(string[] args)
        {
            string TypeOfProgram = "";                                                //(input) type of program required by the user.
            uint digForFC = 0;                                                        //(input) number for factorial calculation
            uint Answer = 0;                                                          //(output) answer for factorial
            uint digForPE = 0;                                                        //(input) number for Prime evaluator
            uint digForFN = 0;                                                        //(input) number for Fibonacci Numbers
            
            bool success = true;                                                      //true/false condition for in program decesion making
            string repetitionResponse;                                                //answer for yes or no question in the end

            //parts of the FN calculation formula
            double part1 = 0;
            double part2 = 0;
            double part3 = 0;
            double part4 = 0;
            double part5 = 0;
            double part6 = 0;


            //display title and explanation to user
            Console.WriteLine("Integer Problem Solver");
            Console.WriteLine("\nThis program shall solve one of a set of common integer problems dependent \nupon a choice made by the user.  Only positive integers shall be permitted.");
            do
            {
    
                //Find which type of calculator the user wants

                do
                {
                    Console.WriteLine("\n\nChoose on of the following.");
                    Console.WriteLine("\nFC - Factorial Calculator");
                    Console.WriteLine("FN - Fibonacci Numbers");
                    Console.WriteLine("PE - Prime Evaluator");

                    Console.Write("\nYour choice:");
                    TypeOfProgram = Console.ReadLine();
                    string typeOfProgram = TypeOfProgram.ToUpper();                              //Changing input to uppercase 
                    typeOfProgram = typeOfProgram.Trim();                                        //trimming unnecessary spacing  
                    Console.Write("\n");
                    //Factorial Calculator
                    if (typeOfProgram == "FC")
                    {
                      
                        do
                        {
                            Console.Write("Enter a number between 0 and 20 for factorial calculation:  "); //Asking user to input digit for the calculation
                            success = uint.TryParse(Console.ReadLine(), out digForFC);                       // Ensuring that the entry is a valid number
                            if(!success)
                            {
                                Console.WriteLine("You must enter a positive integer");
                            }
                            // Calculation For Factorial
                            if(success)
                            {
                                Answer = digForFC;                                                                            
                                
                                for (uint i = 1; i < digForFC; i++)
                                {
                                    Answer = Answer * i;
                                }
                            } 
                        
                        } while (!success);
                        
                        Console.WriteLine("The Value of the factorial, {0}!, is {1}", digForFC, Answer);     //Output- answer to the problem
                        success = true;

                        Console.Write("\n\nType 'Yes' to run the program again: ");                          //Asking the user if they would like to repeat the program
                        repetitionResponse = Console.ReadLine();                                             //Taking users input and saving it
                        repetitionResponse = repetitionResponse.Trim();                                      //Trimming extra spaces on both sides of the input 
                        repetitionResponse = repetitionResponse.ToLower();                                   // changing the input to lowercase

                        // if the input is yes(success=false)
                        if (repetitionResponse == "yes")                                                                               
                        {
                            success = false;
                        }
                        // if the input is no
                        if (repetitionResponse != "no")
                        {
                            success = true;
                        }
                    }

                    //Fibonacci Sequence Calculator
                    if (typeOfProgram == "FN")
                    {
                        do
                        {
                            Console.Write("Enter the number of the desired term in the fibonacci sequence: ");      //Asking user to input digit for the calculation
                            success = uint.TryParse(Console.ReadLine(), out digForFN);                              // Ensuring that the entry is a valid number
                            if (success == false)                                                                   //Show error message
                            {
                                Console.WriteLine("You must enter a positive integer!");
                            }
                                 
                         }while (!success);
                        
                        //Calculations for fibonacci sequence 
                        part1 = Math.Sqrt(5);
                        part2 = (1 + part1)/2;
                        part3 = (1 - part1) / 2;
                        part4 = Math.Pow(part2, digForFN);
                        part5 = Math.Pow(part3, digForFN);
                        part6 = (part4 - part5)/part1;

                        Console.WriteLine("The value of the {0}th term in the fibonacci sequence is {1}", digForFN, part6); //Output- answer to the problem



                        Console.Write("\n\nType 'Yes' to run the program again: ");               //Asking the user if they want to repeat the program
                        repetitionResponse = Console.ReadLine();                            //Reading and saving the input from the user
                        repetitionResponse = repetitionResponse.Trim();                        //Trimming extra spaces on both sides
                        repetitionResponse = repetitionResponse.ToLower();                         //Turning the letters to lowercase

                        if (repetitionResponse == "yes")                               //Making success false when the input is yes
                        {
                            success = false; 
                        }

                        if (repetitionResponse != "no")                                //Making success true when the input is no
                        {
                            success = true;
                        }
                    }

                    //Prime number calculator
                    if (typeOfProgram == "PE")
                    {

                        Console.Write("Enter the number you wish to evaluate for primality: ");       //Asking user to input digit for the calculation
                        success = uint.TryParse(Console.ReadLine(), out digForPE);          //Ensuring that the entry is a valid number

                       
                        Answer = digForPE;                                  //Calculations 
                        for (uint i = 2; i < Answer; i++)
                        {
                            
                            Answer = Answer % i;

                            if(Answer == 0)
                            {
                                Console.WriteLine("THe value, {0}, IS NOT a prime number!", digForPE);         //Output- answer to the problem
                            }
                            if(Answer !=0)
                            {
                                Console.WriteLine("THe value, {0}, IS a prime number!", digForPE);     //Output- answer to the problem
                            }

                            Console.Write("\n\nType 'Yes' to run the program again: ");
                            repetitionResponse = Console.ReadLine();                       //reading and saving the users input
                            repetitionResponse = repetitionResponse.Trim();            //Trimming the extra spaces in the input
                            repetitionResponse = repetitionResponse.ToLower();          //turning the letters to lowercase

                            if (repetitionResponse == "yes")                      //Making success false when the input is yes
                            {
                                success = true;
                            }

                            if (repetitionResponse != "no")                         //Making success true when the input is no
                            {
                                success = false;
                            }
                        }


                    }

                    else
                    {
                        Console.WriteLine("This is not a valid selection!\n");           //Show error message
                        success = false;
                    }

                } while (!success);
                
            } while (!success);

            Console.WriteLine("\n\nThank you for using the integer problem solver.  Goodbye!");      //Let the user know that the program is ending
            Console.WriteLine("\nPress any key to exit...");                                         //ask user for permission to end the program
            Console.ReadKey();
        }
    }
}
