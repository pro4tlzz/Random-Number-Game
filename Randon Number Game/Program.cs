using System;


namespace Randon_Number_Game
{
    class Program
    {

        static void Main(string[] args)
        {
            // Boolean if user passes
            Boolean userPassed = false;
            // Declares Answer Variable
            //  int actualAnswer = 6;
            // Random
            Random r = new Random();
            int actualAnswer = r.Next(0, 30); //for ints
            int range = 30;
            // Declares integer for actual integer, we pass a value as it is needed for scope in if selection
            int userInput = 0;
            Boolean userValid = true;
            // Runs loop until user passes
            while (userPassed == false)
            {
                // Asks user for a number
                Console.WriteLine("Enter a number between 1 and {0}", range );
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
                    Console.WriteLine("Error, please enter a valid whole number. " + ex.Message);
                    // Turns boolean to false if user entered invalid string
                    userValid = false;

                }
                if (userValid == false)
                {
                    // Returns to start if userValid equals false
                    continue;

                }
                else

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
                    Console.WriteLine("The actual answer is less than {0}", userInput);
                    userPassed = false;
                }
                // Checks if input is less than answer
                else
                     if (userInput < actualAnswer)
                {
                    // User Fails
                    Console.WriteLine("The actual answer is greater than {0}", userInput);
                    userPassed = false;
                }

                // Displays Message
                Console.ReadLine();

            }



        }

    }
}
