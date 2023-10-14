using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your user name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber ()
        {
            Console.Write("Please enter your user number: ");
            string usernumber = Console.ReadLine();
            int intusernumber = int.Parse(usernumber);
            return intusernumber;
        }

        static int SquareNumber (int number)
        {
            int squarednumber = number * number;
            return squarednumber;
        }

        static void DisplayResult ()
        {
            DisplayWelcome();
            string UserName = PromptUserName();
            int UserNumber = PromptUserNumber();
            Console.Write("Please enter your favorite number: ");
            string number = Console.ReadLine();
            int intnumber = int.Parse(number);
            int favoriteNumberSquared= SquareNumber(intnumber);
            Console.WriteLine($"{UserName}, the square of your number is {favoriteNumberSquared}.");
        }

        DisplayResult ();
    }

}

