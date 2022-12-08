using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int numToGuess = new Random().Next(20);
            bool bUserContinue = true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("There is a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to quit.");

            // Keep track of the number of guesses and the current user guess
            int usersNum = 0;
            int userAttemptCount = 0;

            // Not used: a small test area
            float fTestNum = 2 * 1.6f;

            // Use a do-while loop because we know we want it to execute at least once
            do
            {
                // Ask the user for their current guess
                Console.WriteLine("What is your guess?");
                string strUserInput = Console.ReadLine();

                // Use the TryParse method to parse the input into a number
                bool result = Int32.TryParse(strUserInput, out usersNum);

                // If the user entered something other than a number ask them again
                if (!result)
                {
                    Console.WriteLine("Sorry, that is not a valid number. Please try again.");
                }
                else
                {
                    // If they enter a -1 then they want to exit the game
                    if (usersNum == -1)
                    {
                        Console.WriteLine($"Ok, program end. The number was {numToGuess}");
                        bUserContinue = false;
                    }
                    else
                    {
                        // Increase the guess count
                        userAttemptCount++;

                        // If they got it right, tell them the guess count and exit
                        if (usersNum == numToGuess)
                        {
                            Console.WriteLine($"You got it correct in {userAttemptCount} guesses.");
                            bUserContinue = false;
                        }
                        else
                        {
                            // Tell them to either guess lower or higher than the previous guess
                            Console.WriteLine("Sorry, it is {0} than that.", usersNum < numToGuess ? "higher" : "lower");
                        }
                    }
                }
            } while (bUserContinue);
        }
    }
}
