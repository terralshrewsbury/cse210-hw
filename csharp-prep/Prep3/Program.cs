using System;

class Program
{
    static void Main(string[] args)
    {
        /*Console.Write("What is the magic number? ");
        string magicNumberStr = Console.ReadLine();*/

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        
        Console.WriteLine("Please try to guess the magic number. ");
        //int.TryParse(magicNumberStr, out int magicNumber);
        int guess;

        do
        {
            Console.Write("What is your guess? ");
            string guessStr = Console.ReadLine();

            int.TryParse(guessStr, out guess);
            

            if (guess == magicNumber)
            {
                Console.Write("Congrats you guessed it! ");
            }
            
            else if ( guess < magicNumber)
            {
                Console.WriteLine("Too Low");
            }
            
            else
            {
                Console.WriteLine("Too High");
            }
            

        } while (guess != magicNumber);
    }
}