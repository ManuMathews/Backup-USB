using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_ManuMathews_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro:
            Console.WriteLine("January 16 2075.");
            Console.ReadLine();
            Console.WriteLine("It's a bright sunny afternoon. you and your A.I., Rufus are hunting 'pink and blue Polka-Dot Lamas' with your newly upgraded Hunting Drone 'Hunt Master 5001'");
            Console.ReadLine();
            Console.WriteLine("Who's on the controls? You or Rufus? Type in 'Me' or 'Rufus'.");
            //end of intro

            // common variables 
            bool moveOn0 = false;
            int modeNumber = 0;
            string guesserEntry;
            Random randomNumber = new Random();


            //deciding if going to case 1 or 2
            do
            {
                guesserEntry = Console.ReadLine();
                guesserEntry = guesserEntry.ToLower();
                guesserEntry = guesserEntry.Trim();

                if (guesserEntry != "me" && guesserEntry != "rufus")
                {
                    moveOn0 = false;
                    Console.WriteLine("Please type in 'Me' or 'Rufus'");
                }
                if (guesserEntry == "me")
                {
                    moveOn0 = true;
                    modeNumber = 2;
                }
                if (guesserEntry == "rufus")
                {
                    moveOn0 = true;
                    modeNumber = 1;
                }
            } while (!moveOn0);



            switch (modeNumber)
            {
                case 1:
                    {//user guesses computers number
                        bool moveOn1 = false;
                        int referenceNumber = randomNumber.Next(0, 35);
                        String userInput;
                        int usersValue;
                        int j = randomNumber.Next(7, 15);
                        int i = 0;

                        //SubIntro:
                        Console.WriteLine("Rufus is on the contols.");
                        Console.ReadLine();
                        Console.WriteLine("Rufus just spotted a Polka-Dot Lama, on the drone's thermal camera, behind a shrub beside a lake.");
                        Console.ReadLine();
                        Console.WriteLine("There are 34 other shrubs beside the lake.");
                        Console.ReadLine();
                        Console.WriteLine("To make it more fun Rufus projects a satellite image for you showing the lake with the shrubs labeled 1 to 34. \n(starting at the north east corner of the lake)");
                        Console.ReadLine();
                        Console.WriteLine("You can guess which shrub is hiding the Polka-Dot Lama to shoot at it with the T640 lazer cannon on your drone.");
                        Console.WriteLine("Enter a number from 1 to 34 to start. And, hurry... the security drones may fly by anytime.");
                        //End-SubIntro.

                        do
                        {
                            moveOn1 = true;
                            userInput = Console.ReadLine();
                            if (int.TryParse(userInput, out usersValue) == false)
                            {
                                moveOn1 = false;
                            }

                            if (usersValue >= 35)
                            {
                                moveOn1 = false;
                            }
                            if (usersValue <= 0)
                            {
                                moveOn1 = false;
                            }
                            if (moveOn1 == false)
                            {
                                Console.WriteLine("Please enter a number from 1 to 34 to use the lazer cannon.");
                            }

                            if (usersValue > referenceNumber && moveOn1 == true)
                            {
                                moveOn1 = false;
                                Console.WriteLine("You aimed too High!");
                            }

                            if (usersValue < referenceNumber && moveOn1 == true)
                            {
                                moveOn1 = false;
                                Console.WriteLine("You aimed too Low!");
                            }

                            if (usersValue == referenceNumber)
                            {
                                moveOn1 = true;
                                Console.WriteLine("Congratulation! You vaporized the Polka-Dot Lama!");
                            }


                            i++;

                            if (i >= j && usersValue != referenceNumber)
                            {
                                moveOn1 = true;
                                Console.Write("Security drones approaching..");
                                Console.ReadLine();
                                Console.Write("Initiating memory wipe and self destruct sequence..");
                                Console.ReadLine();
                                Console.Write("Drone signal lost. Memory wipe succesful.");
                                Console.ReadLine();
                            }
                        } while (moveOn1 == false);
                    }break;



                case 2:
                    {//computer guesses users number
                        //SubIntro:
                        Console.WriteLine("You are on the contols.");
                        Console.ReadLine();
                        Console.WriteLine("You just spotted a Polka-Dot Lama, on the drone's thermal camera, behind a shrub beside a lake.");
                        Console.ReadLine();
                        Console.WriteLine("There are 34 other shrubs beside the lake.");
                        Console.ReadLine();
                        Console.WriteLine("To make it more fun you project a satellite image for Rufus showing the lake with the shrubs labeled 1 to 34. \n(starting at the north east corner of the lake)");
                        Console.ReadLine();
                        Console.WriteLine("Rufus will guess which shrub is hiding the Polka-Dot Lama to shoot at it with the T640 lazer cannon on your drone.");
                        Console.WriteLine("He will guess a number from 1 to 35 to start. Hopefully the security drones will not fly by anytime soon.");
                        Console.WriteLine("Keep the number between 1 and 34 in your mind. Press enter to recieve first guess");
                        Console.ReadLine();
                        //end of SubIntro.

                        //variables
                        int a = 0; //lowest point for guessing numbers
                        int z = 35; //highest point for guessing numbers
                        bool moveOn2 = false;
                        bool moveOn3 = false;
                        int guessNumber;
                        string userReply;

                        //the guessing game:
                        do
                        {
                            guessNumber = randomNumber.Next(a + 1, z);
                            Console.WriteLine("Is the Polka-Dot Lama behind shrub number " + guessNumber + "? \nIf yes, type 'Y'. If not, please type 'L' for too low or 'H' for too high..");

                            do
                            {
                                userReply = Console.ReadLine();
                                userReply = userReply.Trim();
                                userReply = userReply.ToUpper();

                                if(userReply != "L" && userReply != "H" && userReply != "Y")
                                {
                                    moveOn3 = false;
                                    Console.WriteLine("Invalid entry. Please enter 'Y' for yes, 'L' for too low or 'H' for too high.");
                                }

                                if(userReply == "L")
                                {
                                    a = guessNumber;
                                    moveOn3 = true;
                                }

                                if (userReply == "H")
                                {
                                    z = guessNumber;
                                    moveOn3 = true;
                                }

                                if (userReply == "Y")
                                {
                                    moveOn3 = true;
                                    moveOn2 = true;
                                    Console.WriteLine("Rufus vaporized the Polka-Dot Lama!");
                                }

                            } while (moveOn3 == false);

                        } while (moveOn2 == false);
                        
                    }
                    break;

            }

            

            Console.ReadLine();


        }
    }
}
