using System;
using System.Text.RegularExpressions;

namespace Exercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sample Email Regex: ^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$

            CheckValue();
        }

        //Regex Checker Class
        private static void CheckValue()
        {
            //Takes an Email as the correct input
            string InputEmail_Value;

            //Prompt user to enter Regular Expression
            Console.WriteLine("The default expression to check an email.");
            Console.Write("Enter a regular Expression (or press ENTER to use the default): ");
            Regex regex = new Regex(Console.ReadLine());

            //Prompt user to enter Email
            Console.Write("Enter some input: ");
            InputEmail_Value = Console.ReadLine();

            //Run Regex Comparison
            Match match = regex.Match(InputEmail_Value);

            //Output results
            if (match.Success)
            {
                Console.WriteLine(InputEmail_Value + " Matches " + regex.ToString() + "? True");
            }

            else
            {
                Console.WriteLine(InputEmail_Value + " Matches " + regex.ToString() + "? False");
            }
        }
    }
}
