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
            Boolean Userpassed = false;
            // Declares Answer Variable
            // int answer = 6;
            // Random
            Random r = new Random();
            int answer= r.Next(0, 10); //for ints
            int range = 10;
            // Declares integer for actual integer
            int userinput;
            // Runs loop until user passes
            while (Userpassed == false)
            {
                // Asks user for a number
                Console.WriteLine("Enter a number between 1 and 10");
                // Takes User Input as String
                string useranswer = Console.ReadLine();
                // User string converted to Int and error handling
                try
                {
                    userinput = Convert.ToInt32(useranswer);
                    // Checks if input is equal to answer
                    if (userinput == answer)
                    {
                        // User passes
                        Console.WriteLine("Congratulations, you have passed");
                        Userpassed = true;

                    }
                    // Checks if input is greater than answer
                    else
                         if (userinput > answer)
                    {
                        // User Fails
                        Console.WriteLine("The actual answer is less than what you entered");
                        Userpassed = false;
                    }
                    // Checks if input is less than answer
                    else
                         if (userinput < answer)
                    {
                        // User Fails
                        Console.WriteLine("The actual answer is greater than what you entered");
                        Userpassed = false;
                    }
                    // Displays Message
                    Console.ReadLine();
                }

                catch (Exception ex)
                {
                    // Error Message
                    Console.WriteLine("Error, please enter a valid whole number. " + ex.Message );
               
                }



            }


        }

    }
}
