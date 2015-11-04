using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700KihyunLeeLab01
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong bits = 0;
            int avg_bits = 0;                  //number of bits that user enters
            int avg_result = 0;
            int bitran = 0;
            
            //Confirm I have one argument.
            if (args.Count() >= 4)                        //M.M : Changed this to >= from == .. Is this neccessary?
            {
                //Print error and exit 
                PrintError("Invalid number of arguments (" + args.Count() + ")\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", "", true, true, -1);
            }

            if ((args[0] == "bitrun") && (args.Count() > 1)) // Read "bitrun" arguement.
            {
                if (args[1] == "-a") // check if 2nd arguement is -a or not.
                {
                
                    try
                    {
                        avg_bits = int.Parse(args[2]);
                        for (int i = 0; i <= 32; i++)      // bitset checking.
                        {
                            bits = (ulong)i;
                            bitran = 0;
                            for (int h = 0; h < Math.Pow(2, avg_bits); h++)
                            {

                                if ((bits & (ulong)(1 << h)) != 0)
                                {

                                    if ((bits & (ulong)(1 << h + 1)) == 0)
                                    {

                                        bitran++;
                                    }
                                    if (((bits >> 31) == 1) && (i == 0))
                                    {
                                        bitran++;
                                    }

                                }
                                Console.WriteLine(bitran);
                            }
                            avg_result = avg_result + bitran;

                        }


                    }
                    catch (Exception e)
                    {

                        PrintError("Parsing Error on argument \"" + args[2] + "\"\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", e.Message, true, true, -3);
                    }
                   // avg_result = args[]
                    decimal calc = 0;
                  //  calc = (decimal)(avg_bits + 1) / (avg_result);
                    calc = (decimal)Math.Pow(2,avg_bits) / (decimal)avg_result;
               
                    Console.WriteLine(calc.ToString("0.00"));
                    Environment.Exit(0);
                }
                else if (args[1] != "-a") // find the bitruns
                {
                   
                    try
                    {
                        bits = uint.Parse(args[1]); // Converting 1st arg to uint and stored in bits variable.
                        // Correct formet : [Number] 
                        for (int i = 0; i < 32; i++)
                        {

                            if ((bits & (ulong)(1 << i)) != 0)
                            {

                                if ((bits & (ulong)(1 << i + 1)) == 0)
                                {

                                    bitran++;
                                }
                                if (((bits >> 31) == 1) && (i == 0))
                                {
                                    bitran++;
                                }



                            }

                        }
                    }
                    catch (Exception)
                    {
                        PrintError("Parsing Error on argument \"" + args[1] + "\"\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", "", true, true, -1);



                    }
                    Console.WriteLine(bitran);
                }

            }
            else if (args[1] == "-a")                           
            {
                ulong error = 0;
                try
                {
                    for (int i = 2; i < args.Count(); i++)
                    {
                        error = Convert.ToUInt64(args[i]);
                        if (string.IsNullOrEmpty(args[i]) == false)
                        {
                            PrintError("Parsing Error on argument \"" + args[1] + "\"\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", "", true, true, -1);

                        }
                        else if (error < 0)
                        {
                            PrintError("Parsing Error on argument \"" + args[1] + "\"\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", "", true, true, -1);
                        }
                    }
                }
                catch (Exception)
                {
                    PrintError("Parsing Error on argument \"" + args[1] + "\"\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", "", true, true, -1);
                }
               
            }
            else
            {
                PrintError("Parsing Error on argument \"" + args[0] + "\"\nPlease type correct format: bitrun <val> or bitrun <-a> <val>", "", true, true, -1);


            }


         
           

 
        }
        //General print error message 
        static void PrintError(string Err = "Unknown Failure", string Dbg = "",
                                    bool printUsage = true, bool exit = false, int exitVal = 1)
        {


            //Print out error message 
            ConsoleColor currBackColor = Console.BackgroundColor;
            ConsoleColor currForeColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Error: " + Err);
            if (Dbg.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Error.WriteLine(Dbg);
            }
            Console.ForegroundColor = currForeColor;
            Console.BackgroundColor = currBackColor;
            if (printUsage)
                PrintUsage();


            if (exit)
                Environment.Exit(exitVal); //By convention, exit with a value != 0 for error 
        }


        //General usage message 
        static void PrintUsage()
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName +" \nbitrun <val> should be a positive integer between 0 and 4294967295. ");
        } 
       
    }
}
