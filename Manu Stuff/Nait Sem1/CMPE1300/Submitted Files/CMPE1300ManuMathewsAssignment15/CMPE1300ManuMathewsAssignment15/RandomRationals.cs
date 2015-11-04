using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsAssignment15
{
    class RandomRationals
    {
        static void Main(string[] args)
        {
            bool exit = false;

            do
            {
                double maxValue = 1.0;
                double minValue = 0.0;
                int numberOfValues = 0;
                double averageOfNumbers = 0.00;

                Console.WriteLine("Random Rational Value Generator\n\n");
                numberOfValues = GetIntValue("How many values would you like to generate in each range?  ", "Only integers above 0 can be entered", 0, 5000);


                averageOfNumbers = GetRandomValues(numberOfValues);
                Console.WriteLine();
                Console.WriteLine("Minimum Value: 0.0\tMaximum Value: 1.0\tAverage of values: {0:f1}", averageOfNumbers);


                maxValue = GetDoubleValue("\n\nEnter the maximum random value to be generated:  ", "Please enter a valid number");

                averageOfNumbers = GetRandomValues(numberOfValues, maxValue);
                Console.WriteLine();
                Console.WriteLine("Minimum Value: 0.0\tMaximum Value: {0:f1}\tAverage of values: {1:f1}", maxValue, averageOfNumbers);

                maxValue = GetDoubleValue("\n\nEnter the maximum random value to be generated:  ", "Please enter a valid number");
                minValue = GetDoubleValue("\nEnter the minimum random value to be generated:  ", "Please enter a valid number");

                double[] randomValues = GetRandomValues(numberOfValues, maxValue, minValue);
                

                double average = 0.0;
                for (int i = 0; i < numberOfValues; i++)
                {
                    average = average + randomValues[i];
                }

                average = average / numberOfValues;
                Console.WriteLine("\nMinimum Value: {2:f1}\tMaximum Value: {0:f1}\tAverage of values: {1:f1}", maxValue, average, minValue);

                Console.WriteLine("\n\nRandom values between {0} and {1} in reverse...\n", minValue, maxValue);


                InReverse(randomValues, numberOfValues);

                Console.Write("\n\n\nPress X to exit or any other key to continue...");
                ConsoleKeyInfo keyInput = Console.ReadKey();
                if (keyInput.Key == ConsoleKey.X)
                {
                    exit = true;
                }
                if (keyInput.Key != ConsoleKey.X)
                {
                    exit = false;
                    Console.Clear();
                }
            } while(!exit);
            
        }
        //End of Main______________________________End of Main__________________________________End of Main_______________________End of Main_______________________


        static double GetRandomValues(int numberOfValues)//generates array 1
        {
            double[] randomValues = new double[numberOfValues + 1];
            Random random = new Random();
            double number;
            bool success = true;



            for (int i = 0; i < numberOfValues + 1; i++)
            {
                
                do
                {
                    number = random.NextDouble();


                } while (!success);
                randomValues[i] = number;
            }



            Console.WriteLine("\n\nRandom values between 0.0 and 1.0 ...\n");
            
            
            
            int f = 0;

            do
            {
                Console.Write("{0:f1}\t", randomValues[f]);
                f = f + 1;
            } while (f != numberOfValues);

            double average = 0.0;
            for (int i = 0; i < numberOfValues; i++)
            {
                average += randomValues[i];
            }

            average = average / numberOfValues;

            return average;
        }
        //End of Method___________________________End of Method______________________End of Method___________________________End of Method______________________

        static double GetRandomValues(int numberOfValues, double maxValue)//generates array 2
        {

            
            double[] randomValues = new double[numberOfValues + 1];
            int a = -1;
            Random random = new Random();
            double number;
            bool success = true;



            for (int i = 0; i < numberOfValues ; i++)
            {
                a = i;
                do
                {
                    number = random.NextDouble() * maxValue;


                } while (!success);
                randomValues[a] = number;
            }


            Console.WriteLine("\nRandom values between 0.00 and {0} ...\n", maxValue);




            int f = 0;
            do
            {
                
                Console.Write("{0:f1}\t", randomValues[f]);
                f = f + 1;
            } while (f != numberOfValues);


            double average = 0.0;
            for (int i = 0; i < numberOfValues; i++)
            {
                average += randomValues[i];
            }

            average = average / numberOfValues;

            return average;


        }
        //End of Method__________________End of Method______________End of Method___________End of Method_________________________________________________________

        static double[] GetRandomValues(int numberOfValues, double maxValue, double minValue)//generates array 3
        {
            double[] randomValues = new double[numberOfValues];
            int a = -1;
            Random random = new Random();
            double number;
            bool success = true;



            for (int i = 0; i < numberOfValues; i++)
            {
                a = i;
                do
                {
                    number = random.NextDouble() * (maxValue - minValue) + minValue;


                } while (!success);
                randomValues[a] = number;
            }


            Console.WriteLine("\nRandom values between {1} and {0} ...\n", maxValue, minValue);




            int f = 0;
            do
            {
                Console.Write("{0:f1}\t", randomValues[f]);
                f = f + 1;
            } while (f != numberOfValues);

            return randomValues;   

        }
        //End of Method___________________End of Method______________________End of Method______________End of Method__________________________________________
        
        static double GetDoubleValue(string requirementStatement, string errorMessage)//method to get max and min values
        {
            double doubleNumber = 0;
            bool success = false;

            do
            {
                Console.Write(requirementStatement);
                success = double.TryParse(Console.ReadLine(), out doubleNumber); 
                if(!success)
                {
                    Console.WriteLine(errorMessage);
                }

            }while (!success);

            return doubleNumber;
        }
        //End of Method___________________End of Method_________________________End of Method_____________End of Method______________________________________

        static int GetIntValue(string requirementStatement, string errorMesssage, int minNumber, int maxNumber)//gets the number of values to be generated
        {
            int number;
            bool success = false;

            Console.Write(requirementStatement);
            do
            {
                success = int.TryParse(Console.ReadLine(), out number);
                if(!success)
                {
                    Console.WriteLine(errorMesssage);
                }
                if(number < minNumber)
                {
                    Console.WriteLine(errorMesssage);
                    success = false;
                }
                if(number > maxNumber)
                {
                    Console.WriteLine(errorMesssage);
                    success = false;
                }


            }while(!success);
            return number;
        }
        //End of Method__________________End of Method____________________End of Method______________________End of Method_______________________________________
        
        static void InReverse(double[] toBeReversed, int numberOfValues)
        {
            Array.Reverse(toBeReversed);

            foreach (double value in toBeReversed)
                Console.Write("{0:f1}  ", value);
        }

        
        
        //End of Method___________________End of Method______________________End of Method______________End of Method__________________________________________
      













    }
}
