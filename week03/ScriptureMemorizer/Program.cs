using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>();

        scriptures.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all thine heart and lean not unto thine own understanding."
        ));

        scriptures.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
        ));

        scriptures.Add(new Scripture(
            new Reference("2 Nephi", 2, 25),
            "Adam fell that men might be; and men are, that they might have joy."
        ));

        // Pick one at random
        Random picker = new Random();
        int index = picker.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[index];

        // Main interaction loop
        while (true)
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());

            if (selectedScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\nAll words are hidden. Press Enter to exit.");
                Console.ReadLine();
                break;
            }

            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            // Handle null or whitespace safely
            if (!string.IsNullOrWhiteSpace(input))
            {
                string lowered = input.ToLower();
                if (lowered == "quit")
                {
                    break;
                }
            }

            // If the user just pressed Enter (empty input), continue hiding
            selectedScripture.HideRandomWords(3);
        }
    }
}
