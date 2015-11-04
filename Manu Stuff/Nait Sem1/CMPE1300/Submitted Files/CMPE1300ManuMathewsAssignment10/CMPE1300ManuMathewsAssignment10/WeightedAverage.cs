using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1300ManuMathewsAssignment10
{
    class WeightedAverage
    {
        static void Main(string[] args)
        {

            double numberOfGrades = 0;
            double gradeOne = 0;
            double weightOne = 0;
            double gradeTwo = 0;
            double weightTwo = 0;
            double gradeThree = 0;
            double weightThree = 0;
            double gradeFour = 0;
            double weightFour = 0;
            double gradeFive = 0;
            double weightFive = 0;
            double gradeSix = 0;
            double weightSix = 0;
            double gradeSeven = 0;
            double weightSeven = 0;
            double gradeEight = 0;
            double weightEight = 0;
            double gradeNine = 0;
            double weightNine = 0;
            double gradeTen = 0;
            double weightTen = 0;
            double addWeights = 0;
            double gradeTimesWeights = 0;
            bool success = false;
            string yesOrNo = "";
            double answer = 0;

            Console.WriteLine("Welcome to the Weighted Grade Average Calculator!");

            do
            {

                do
                {
                    Console.Write("\n\nPlease enter the number of grades that you wish to average (max. 10):   ");
                    success = double.TryParse(Console.ReadLine(), out numberOfGrades);

                    if (!success)
                    {
                        Console.WriteLine("You have entered an invalid value");
                    }

                    if (success && numberOfGrades < 1 || numberOfGrades > 10)
                    {
                        Console.WriteLine("The entry is out of range.");
                        success = false;
                    }
                } while (!success);

                if (numberOfGrades == 1)
                {
                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne;
                    gradeTimesWeights = (gradeOne * weightOne);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}.", answer);
                }



                if (numberOfGrades == 2)
                {
                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne + weightTwo;
                    gradeTimesWeights = (gradeOne * weightOne) + (gradeTwo * weightTwo);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}.", answer);


                }


                if (numberOfGrades == 3)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne + weightTwo + weightThree;
                    gradeTimesWeights = (gradeOne * weightOne) + (gradeTwo * weightTwo) + (gradeThree * weightThree);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);

                }


                if (numberOfGrades == 4)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //4


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFour < 1 || gradeFour > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFour < 1 || weightFour > 40)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne + weightTwo + weightThree + weightFour;
                    gradeTimesWeights = (gradeOne * weightOne) + (gradeTwo * weightTwo) + (gradeThree * weightThree) + (gradeFour * weightFour);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);

                }

                    if (numberOfGrades == 5)
                    {
                        //1


                        do
                        {
                            Console.Write("\n\nPlease enter the value for grade item #1:   ");
                            success = double.TryParse(Console.ReadLine(), out gradeOne);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && gradeOne < 1 || gradeOne > 100)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }
                        } while (!success);

                        do
                        {
                            Console.Write("Please enter the weight of item #1:   ");
                            success = double.TryParse(Console.ReadLine(), out weightOne);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && weightOne < 1 || weightOne > 50)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }

                        } while (!success);






                        //2


                        do
                        {
                            Console.Write("\n\nPlease enter the value for grade item #2:   ");
                            success = double.TryParse(Console.ReadLine(), out gradeTwo);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && gradeTwo < 1 || gradeOne > 100)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }
                        } while (!success);

                        do
                        {
                            Console.Write("Please enter the weight of item #2:   ");
                            success = double.TryParse(Console.ReadLine(), out weightTwo);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && weightTwo < 1 || weightTwo > 50)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }

                        } while (!success);



                        //3




                        do
                        {
                            Console.Write("\n\nPlease enter the value for grade item #3:   ");
                            success = double.TryParse(Console.ReadLine(), out gradeThree);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && gradeThree < 1 || gradeThree > 100)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }
                        } while (!success);

                        do
                        {
                            Console.Write("Please enter the weight of item #3:   ");
                            success = double.TryParse(Console.ReadLine(), out weightThree);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && weightThree < 1 || weightThree > 50)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }

                        } while (!success);


                        //4


                        do
                        {
                            Console.Write("\n\nPlease enter the value for grade item #4:   ");
                            success = double.TryParse(Console.ReadLine(), out gradeFour);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && gradeFour < 1 || gradeFour > 100)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }
                        } while (!success);

                        do
                        {
                            Console.Write("Please enter the weight of item #4:   ");
                            success = double.TryParse(Console.ReadLine(), out weightFour);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && weightFour < 1 || weightFour > 40)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }

                        } while (!success);


                        //5


                        do
                        {
                            Console.Write("\n\nPlease enter the value for grade item #5:   ");
                            success = double.TryParse(Console.ReadLine(), out gradeFive);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && gradeFive < 1 || gradeFive > 100)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }
                        } while (!success);

                        do
                        {
                            Console.Write("Please enter the weight of item #5:   ");
                            success = double.TryParse(Console.ReadLine(), out weightFive);
                            if (!success)
                            { Console.WriteLine("Value entered is invalid."); }

                            if (success && weightFive < 1 || weightFive > 50)
                            {
                                Console.WriteLine("Value entered is invalid.");
                                success = false;
                            }

                        } while (!success);

                        addWeights = weightOne + weightTwo + weightThree + weightFour + weightFive;
                        gradeTimesWeights = (gradeOne * weightOne) + (gradeTwo * weightTwo) + (gradeThree * weightThree) + (gradeFour * weightFour) + (gradeFive * weightFive);
                        answer = gradeTimesWeights / addWeights;
                        answer = Math.Round(answer, 2);

                        Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);

                    }

                if (numberOfGrades == 6)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //4


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFour < 1 || gradeFour > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFour < 1 || weightFour > 40)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //5


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFive < 1 || gradeFive > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFive < 1 || weightFive > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    //6



                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSix < 1 || gradeSix > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSix < 1 || weightSix > 60)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne + weightTwo + weightThree + weightFour + weightFive + weightSix;
                    gradeTimesWeights = (gradeOne * weightOne) + (gradeTwo * weightTwo) + (gradeThree * weightThree) + (gradeFour * weightFour) + (gradeFive * weightFive) + (gradeSix * weightSix);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);

                }

                if (numberOfGrades == 7)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeTwo > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //4


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFour < 1 || gradeFour > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFour < 1 || weightFour > 40)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //5


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFive < 1 || gradeFive > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFive < 1 || weightFive > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    //6



                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSix < 1 || gradeSix > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSix < 1 || weightSix > 60)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //7

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSeven < 1 || gradeSeven > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSeven < 1 || weightSeven > 70)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne+ weightTwo+ weightThree+ weightFour+ weightFive+ weightSix+ weightSeven;
                    gradeTimesWeights = (gradeOne* weightOne) + (gradeTwo* weightTwo) + (gradeThree* weightThree) + (gradeFour * weightFour) + (gradeFive * weightFive) + (gradeSix * weightSix) + (gradeSeven * weightSeven);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);
                    
                }

                if (numberOfGrades == 8)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //4


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFour < 1 || gradeFour > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFour < 1 || weightFour > 40)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //5


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFive < 1 || gradeFive > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFive < 1 || weightFive > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    //6



                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSix < 1 || gradeSix > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSix < 1 || weightSix > 60)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //7

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSeven < 1 || gradeSeven > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSeven < 1 || weightSeven > 70)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //8

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #8:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeEight);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeEight < 1 || gradeEight > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #8:   ");
                        success = double.TryParse(Console.ReadLine(), out weightEight);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightEight < 1 || weightEight > 80)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    addWeights = weightOne+ weightTwo+ weightThree+ weightFour+ weightFive+ weightSix+ weightSeven+ weightEight;
                    gradeTimesWeights = (gradeOne* weightOne) + (gradeTwo* weightTwo) + (gradeThree* weightThree) + (gradeFour * weightFour) + (gradeFive * weightFive) + (gradeSix * weightSix) + (gradeSeven * weightSeven) + (gradeEight * weightEight);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);

                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);


                }

                if (numberOfGrades == 9)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //4


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFour < 1 || gradeFour > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFour < 1 || weightFour > 40)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //5


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFive < 1 || gradeFive > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFive < 1 || weightFive > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    //6



                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSix < 1 || gradeSix > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSix < 1 || weightSix > 60)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //7

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSeven < 1 || gradeSeven > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSeven < 1 || weightSeven > 70)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //8

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #8:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeEight);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeEight < 1 || gradeEight > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #8:   ");
                        success = double.TryParse(Console.ReadLine(), out weightEight);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightEight < 1 || weightEight > 80)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //9


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #9:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeNine);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeNine < 1 || gradeNine > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the wNine of item #9:   ");
                        success = double.TryParse(Console.ReadLine(), out weightNine);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightNine < 1 || weightNine > 90)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);
                    
                    addWeights = weightOne+ weightTwo+ weightThree+ weightFour+ weightFive+ weightSix+ weightSeven+ weightEight+ weightNine;
                    gradeTimesWeights = (gradeOne* weightOne) + (gradeTwo* weightTwo) + (gradeThree* weightThree) + (gradeFour * weightFour) + (gradeFive * weightFive) + (gradeSix * weightSix) + (gradeSeven * weightSeven) + (gradeEight * weightEight) + (gradeNine * weightNine);
                    answer = gradeTimesWeights / addWeights;
                    answer = Math.Round(answer, 2);


                    Console.WriteLine("Your weighted average for the supplied grades is {0:F2}", answer);
                    
                }

                if (numberOfGrades == 10)
                {
                    //1


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeOne < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #1:   ");
                        success = double.TryParse(Console.ReadLine(), out weightOne);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightOne < 1 || weightOne > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);






                    //2


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTwo < 1 || gradeOne > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #2:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTwo);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTwo < 1 || weightTwo > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //3




                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeThree < 1 || gradeThree > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #3:   ");
                        success = double.TryParse(Console.ReadLine(), out weightThree);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightThree < 1 || weightThree > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //4


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFour < 1 || gradeFour > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #4:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFour);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFour < 1 || weightFour > 40)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //5


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeFive < 1 || gradeFive > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #5:   ");
                        success = double.TryParse(Console.ReadLine(), out weightFive);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightFive < 1 || weightFive > 50)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);

                    //6



                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSix < 1 || gradeSix > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #6:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSix);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSix < 1 || weightSix > 60)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //7

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeSeven < 1 || gradeSeven > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #7:   ");
                        success = double.TryParse(Console.ReadLine(), out weightSeven);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightSeven < 1 || weightSeven > 70)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);



                    //8

                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #8:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeEight);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeEight < 1 || gradeEight > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the weight of item #8:   ");
                        success = double.TryParse(Console.ReadLine(), out weightEight);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightEight < 1 || weightEight > 80)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //9


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #9:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeNine);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeNine < 1 || gradeNine > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the wNine of item #9:   ");
                        success = double.TryParse(Console.ReadLine(), out weightNine);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightNine < 1 || weightNine > 90)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


                    //10


                    do
                    {
                        Console.Write("\n\nPlease enter the value for grade item #10:   ");
                        success = double.TryParse(Console.ReadLine(), out gradeTen);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && gradeTen < 1 || gradeTen > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }
                    } while (!success);

                    do
                    {
                        Console.Write("Please enter the wTen of item #10:   ");
                        success = double.TryParse(Console.ReadLine(), out weightTen);
                        if (!success)
                        { Console.WriteLine("Value entered is invalid."); }

                        if (success && weightTen < 1 || weightTen > 100)
                        {
                            Console.WriteLine("Value entered is invalid.");
                            success = false;
                        }

                    } while (!success);


        addWeights = weightOne + weightTwo + weightThree + weightFour + weightFive + weightSix + weightSeven + weightEight + weightNine + weightTen;
        gradeTimesWeights = (gradeOne * weightOne) + (gradeTwo * weightTwo) + (gradeThree * weightThree) + (gradeFour * weightFour) + (gradeFive * weightFive) + (gradeSix * weightSix) + (gradeSeven * weightSeven) + (gradeEight * weightEight) + (gradeNine * weightNine) + (gradeTen * weightTen);
        answer = addWeights / gradeTimesWeights;
        answer = Math.Round(answer, 2);

                    Console.WriteLine("\n\nYour weighted average for the supplied grades is {0:F2}.", answer);
                
                
                }

                do
                {
                    Console.Write("\n\nDo you wish to perform another average? (yes/no):  ");
                    yesOrNo = Console.ReadLine();
                    yesOrNo = yesOrNo.Trim();
                    yesOrNo = yesOrNo.ToLower();


                    success = !success;

                    if (yesOrNo == "yes")
                    {
                        success = true;
                    }

                    if (yesOrNo == "no")
                    {
                        success = true;
                    }

                    

                } while (success == false);

           if (yesOrNo == "no")
           {
                success = true;
           }

           if (yesOrNo == "yes")
           {
                success = false;
           }

            } while (!success);


            


            


            Console.WriteLine("\n\nThank you for Using the Weighted Average Calculator!  See ya!\n\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
