using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();

        int sum = 0;
        while (true)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            numbers.Add(number);
            if (number == 0)
            {
                break;
            }
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");
    }
}