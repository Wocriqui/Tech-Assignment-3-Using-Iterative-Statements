/*  
    Author: William Criqui
    Date: 2/10/2022
    Comments: This C# Console application utilizes iterative statements
              after getting input from users to convert CAD to USD
 
 */


using System;

namespace Tech_Assignment_3_Using_Iterative_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Ask the user for input */
            Console.Write("Enter a CAD increment value between 5 and 25: ");

            /* Using a try catch block to validate input from the user */
            try
            {
                // This Variable gathers input from the user
                String input = Console.ReadLine();

                // This Varible provide the baseline for the incremented conversion table
                int CAD = 0;

                // This variable is used to perform the iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                
                // This variable establishes the conversion rate
                double conversion_rate = 0.792367;
                
                // This IF statement provides the building blocks for the while loop
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("Executing Conversion");
           
                    // This While loop performs the iterative statement 
                    while ((CAD >= 0) && (CAD <= 200)) 
                    {
                        // This variable established the U.S. Dollar value converted from CAD
                        decimal USD = (decimal)(CAD * conversion_rate);

                        // These lines write the CAD and USD values into the conversion table
                        Console.WriteLine("CAD: " + CAD.ToString() + " USD: " + USD.ToString());
                        CAD += value_of_input;
                        USD += value_of_input;
                    }

                    Console.WriteLine("Press any key to exit the program ... ");
                    // Pause the program and allow the user to end the program
                    Console.ReadKey(true);
                }

            }
            catch 
            {
                Console.WriteLine("Please enter a valid integer and try running the program again ...");
                Console.WriteLine("Press any key to exit the program and try again ...");
                Console.ReadKey(true);
            } // End of the catch
        } // End of Main
    } // End of class
} // End of namespace
