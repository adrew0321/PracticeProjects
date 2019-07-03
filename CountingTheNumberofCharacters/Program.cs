using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingTheNumberofCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will create a program that prompts for an input string and displays output that shows the input string and the number of characters the string contains..
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            string userInput;
            int numberOfCharactersInUserInput;
            string playAgainResponse;
            bool playAgain;

            while (true)
            {
                Console.WriteLine("Counting The Number Of Characters \n");
                Console.WriteLine("This program will take in the users input and count the number of characters in the users response \n");
                Console.WriteLine("For Example: \n\n" +
                    "\t What is your input? Basketball \n" +
                    "\t Basketball has 10 characters. \n");
                Console.WriteLine("---------------------------------------------------------------------- \n");

                Console.Write("What is your input? ");
                userInput = Console.ReadLine();
                numberOfCharactersInUserInput = userInput.Length;

                GetNumberOfCharacters(userInput, numberOfCharactersInUserInput);
                Console.WriteLine($"\"{userInput}\" has {numberOfCharactersInUserInput} characters \n");

                playAgain = true;
                while (playAgain)
                {
                    Console.WriteLine("Would you like to play again? (Yes or No)");
                    playAgainResponse = Console.ReadLine().ToLower();

                    if (playAgainResponse == "yes" || playAgainResponse == "y")
                    {
                        playAgain = true;
                        System.Console.Clear();
                        break;
                    }
                    else if (playAgainResponse == "no" || playAgainResponse == "n" )
                    {
                        playAgain = false;
                        Console.WriteLine("\nUnderstood, thank you for playing!");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("\nInput not accepted. Please try again...");

                    }

                }

            }

        }

        private static void GetNumberOfCharacters(string input, int numberOfCharacters)
        {
            input = Console.ReadLine().Trim();
            numberOfCharacters = input.Length;
        }


    }
}
