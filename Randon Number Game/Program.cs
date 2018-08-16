using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randon_Number_Game
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Boolean if user passes
            Boolean userPassed = false;
            // Declares Answer Variable
            int actualAnswer = 6;
            // Declares integer for actual integer, we pass a value as it is needed for scope in if selection
            int userInput = 0;
            // Runs loop until user passes
            while (userPassed == false)
            {
                // Asks user for a number
                Console.WriteLine("Enter a number between 1 and 10");
                // Takes User Input as String
                string userAnswer = Console.ReadLine();
                // User string converted to Int and error handling
                try
                {
                    userInput = Convert.ToInt32(userAnswer);
                   
                }

                catch (Exception ex)
                {
                    // Error Message
                    Console.WriteLine("Error, please enter a valid whole number. " + ex.Message );
               
                }
                // Checks if input is equal to answer
                if (userInput == actualAnswer)
                {
                    // User passes
                    Console.WriteLine("Congratulations, you have passed");
                    userPassed = true;

                }
                // Checks if input is greater than answer
                else
                     if (userInput > actualAnswer)
                {
                    // User Fails
                    Console.WriteLine("The actual answer is less than what you entered");
                    userPassed = false;
                }
                // Checks if input is less than answer
                else
                     if (userInput < actualAnswer)
                {
                    // User Fails
                    Console.WriteLine("The actual answer is greater than what you entered");
                    userPassed = false;
                }
                // Displays Message
                Console.ReadLine();


            }


        }

    }
}
