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
            Class1 c = new Class1();
            // Boolean for user diff
            Boolean userDiff = false;
            while (userDiff == false)
            {
                Console.WriteLine("Please choose a difficulty level, easy , hard or medium");
                string userdiff = Console.ReadLine();
                if (userdiff == "easy")
                {/*
                // insert random easy
                Random r = new Random();
            int answer= r.Next(0, 10); //for ints
               string eRange = 10 
                userDiff = true;
                */
                    randomgen();
                }

                else
                    if (userdiff == "medium")
                {/*
                  //  insert random medium
                    Random r = new Random();
            int answer= r.Next(0, 30); //for ints
                    string eRange = 30 
                    userDiff = true;*/
                    randomgen();
                }
                else
                    if (userdiff == "hard")
                {/*
                    userDiff = true;
               // insert random hard
                    Random r = new Random();
            int answer= r.Next(0, 100); //for ints
                    string eRange = 100;*/
                    randomgen();
                }
                else
                {
                    Console.WriteLine("Please enter a valid difficulty {0}");
                }


                // Boolean if user passes
                Boolean Userpassed = false;
                // Declares Answer Variable
                // int answer = 6;
                // Random
                Random r = new Random();
                int answer = r.Next(0, 30); //for ints
                int range = 30;
                // Declares integer for actual integer
                int userinput;
                // Runs loop until user passes
                while (Userpassed == false)
                {
                    // Asks user for a number
                    Console.WriteLine("Enter a number between 1 and {0}", eRange);
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
                        Console.WriteLine("Error, please enter a valid whole number. " + ex.Message);

                    }



                }




            }



        }
        public class Class1
        {

            public static void randomgen()
            {
                // Random
                Random r = new Random();
                int answer = r.Next(0, 30); //for ints
                int range = 30;
            }
        }
    }
}


