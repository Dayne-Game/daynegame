using System;

namespace daynegame234
{
    class Program
    {
        static void Main(string[] args)
        {
        //Start the program with Clear();
        Console.Clear();
        //get user input
       
        // Console.WriteLine("Q1 - aks and display names");       
        // System.Console.WriteLine("******************************");
        // System.Console.Write("Please enter your firstname:");
        // var name = Console.ReadLine();
        // System.Console.WriteLine($"Your firstname is {name}");
        // System.Console.WriteLine("");
        // // System.Console.WriteLine("******************************");
        // System.Console.Write("Please enter lastname:");
        // var lastname = Console.ReadLine();
        // System.Console.WriteLine($"Your lastname is {lastname}");
        // System.Console.WriteLine("");
        // // System.Console.WriteLine("******************************");
        // Console.WriteLine("");
        // System.Console.WriteLine($"So your full name is {name} {lastname}");
        // System.Console.WriteLine("*********************************");
        // Console.WriteLine("Q2 - Ask the user for a number input");
        // Console.WriteLine("************************************");
        // bool keepgoing = true;

        // do
        // {
        //     Console.WriteLine("Please enter a number");
        //     var numberinput = Console.ReadLine();
        //     var number1 = int.Parse(numberinput);
        // }
        // while (keepgoing == true);
        // {
        //     Console.ReadLine();
        // }

        bool domile = true;

        do
        {
                Console.WriteLine("Enter the code for what you want to convert");
                Console.WriteLine("");
                Console.WriteLine("Kilometres to Miles           Code: KTM");
                Console.WriteLine("Miles to Kilometres           Code: MTK");
                Console.WriteLine("");
                Console.WriteLine("QUIT                          Code:QUIT");
				Console.WriteLine("");
                Console.Write("Enter Code:");

                var KTM = "KTM";
                var MTK = "MTK";
                var userinput = Console.ReadLine();
                var QUIT = "QUIT";

                if (userinput == MTK)
                {
                    Console.WriteLine("ENTER THE NUMBER OF MILES TO KILOMETRES:");
                    double number = double.Parse(Console.ReadLine());
                    double convertedNumber = Math.Round(number * 1.60934, 2);
                    Console.WriteLine("");
                    Console.WriteLine($"{convertedNumber}KM");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS ENTER TO DO ANOTHER CALCULATION OR PRESS ENTER THEN TYPE QUIT TO QUIT THE APP");
                    Console.ReadLine();
                }
                else if (userinput == KTM)
                {
                    Console.WriteLine("ENTER THE NUMBER OF KILOMETRES TO MILES:");
                    double number = double.Parse(Console.ReadLine());
                    double convertedNumber = Math.Round(number * 0.62137119, 2);
                    Console.WriteLine("");
                    Console.WriteLine($"{convertedNumber}MILES");
                    Console.WriteLine("");
                    Console.WriteLine("PRESS ENTER TO DO ANOTHER CALCULATION OR PRESS ENTER THEN TYPE QUIT TO QUIT THE APP");
                    Console.ReadLine();  
                }
                else if (userinput == QUIT)
                {
                    domile = false;
                    Console.WriteLine("THANK YOU FOR USING THE APPLICATION PRESS ENTER TO CLOSE");
                }
                else 
                {
                    Console.WriteLine("");
                    Console.WriteLine("YOU DIDN'T ENTER THE RIGHT CODE PRESS ENTER TO START AGAIN");
                    Console.ReadLine();
                }
            
        }
        while(domile == true);
        {
            Console.ReadLine();
        }
        //End the program with blank line and instructions
        Console.ResetColor();
        Console.WriteLine();
        Console.WriteLine("Press <Enter> to quit the program");
        Console.ReadKey();
        }
    }
}
