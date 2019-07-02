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

            Console.WriteLine("Counting The Number Of Characters \n");
            Console.WriteLine("This program will take in the users input and count the number of characters in the users response \n");
            Console.WriteLine("For Example: \n\n" +
                "\t What is your input? Basketball \n" +
                "\t Basketball has 10 characters. \n");

            Console.WriteLine("---------------------------------------------------------------------- \n");

            Console.Write("What is your input? ");
            string userInput = Console.ReadLine().Trim();
            int numberOfCharactersInUserInput = userInput.Length;

            Console.WriteLine($"{userInput} has {numberOfCharactersInUserInput} characters \n");


        }
    }
}
