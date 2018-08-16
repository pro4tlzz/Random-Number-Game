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
            // SDeclares Answer Variable
            int answer = 6;
            // Asks user for a number
            Console.WriteLine("Enter a number between 1 and 10");
            // Displays Message
            Console.ReadLine();
            // Takes User Input as String
            string useranswer = Console.ReadLine();
            //
            int userinput;
            if (!int.TryParse(useranswer, userinput))
            {
                Console.WriteLine("Please Write")
            }
            
        }
    }
}
