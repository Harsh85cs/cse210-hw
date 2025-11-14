using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your score?");
        string scoreInput = Console.ReadLine();
        int score = int.Parse(scoreInput);

        if (score >= 90)
        {
            if (score  >= 97)
            {
                Console.WriteLine("Your grade is A+.");
            }
            else if (score >= 93)
            {
                Console.WriteLine("Your grade is A-.");
            }
            else
            {
                Console.WriteLine("Your grade is A.");
            }
        }
        else if (score >= 80)
        {
            Console.WriteLine("Your grade is B.");
        }
        else if (score >= 70)
        {
            Console.WriteLine("Your grade is C.");
        }
        else if (score >= 60)
        {
            Console.WriteLine("Your grade is D.");
        }
        else
        {
            Console.WriteLine("Your grade is F.");
        }

    }
}