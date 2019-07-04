using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingQuotes
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will prompts for a quote and an author, then will display the quotation and author as shown in the example output.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            string userQuote;
            string authorOfQuote;


            Console.WriteLine("Printing Quotes \n");
            Console.WriteLine("This program will prompt for a quote and an author, then will display the quotation and author as shown in the example output. \n");
            Console.WriteLine("For Example: \n\n" +
                "\t What is your quote? \"You wanna go to jail, or go home, Jake?\" \n" +
                "\t Who said it? Denzel Washington \n" + "\n\t Denzel Washington said, \"You wanna go to jail or go home, Jake?\"");
            Console.WriteLine("---------------------------------------------------------------------- \n");

            Console.Write("What is your quote? ");
            userQuote = Console.ReadLine();

            Console.Write("Who said it? ");
            authorOfQuote = Console.ReadLine();

            Console.WriteLine($"\n{authorOfQuote} said, \"{userQuote}\"");

        }
    }
}
