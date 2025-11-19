using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        int magicNumber = 0;
        while (magicNumber != 7)
        {
            Console.Write("What is your guess the magic number?");
            string userInput = Console.ReadLine();
            magicNumber = int.Parse(userInput);
            if (magicNumber > 7)
            {
                Console.WriteLine("Too high, try again.");
            }
            else if (magicNumber < 7)
            {
                Console.WriteLine("Too low, try again.");
            }
            else
            {
                Console.WriteLine("You guessed the magic number!");
            }
        }
    }
}