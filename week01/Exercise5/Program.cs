using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();

        string name = PromptUserName();
        int favoriteNumber = PromptUserNumber();
        int squaredNumber = SquareNumber(favoriteNumber);
        DisplayResult(name, squaredNumber);
    }
        
    static void DisplayWelcome()
    {
            Console.WriteLine("Welcome to the Program!");
  
    }

    static string PromptUserName()
    {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
    }
    static int  PromptUserNumber()
    {
            Console.Write("Please enter your favorite number: ");
            string numberString = Console.ReadLine();
            int number = int.Parse(numberString);
            return number;
    }
    static int SquareNumber(int number)
    {
            int squared = number * number;
            return squared;
    }
    static void DisplayResult(string name, int squaredNumber)
    {
            Console.WriteLine($"{name}, the square of your favorite number is {squaredNumber}.");
    }
       
    
}