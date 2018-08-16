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
            Boolean Userpassed;
            // SDeclares Answer Variable
            int answer = 6;
            // Asks user for a number
            Console.WriteLine("Enter a number between 1 and 10");
            // Displays Message
            Console.ReadLine();
            // Takes User Input as String
            string useranswer = Console.ReadLine();
            // Declares integer for actual integer
            int userinput;
            
            // User string parsed to Int
            if (!int.TryParse(useranswer, out userinput))
            {
                // Exception
                Console.WriteLine("Please enter a valid number");
            }
            if (userinput == answer)
            {
                Console.WriteLine("Congratulations, you have passed");
            }
           
            
        }
    }
}
