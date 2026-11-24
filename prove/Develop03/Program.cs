
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: This program selects only words that have not
        // already been hidden, preventing unnecessary repeated selections.
        // It also supports both single-verse and multiple-verse references.

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart; " +
                      "and lean not unto thine own understanding. " +
                      "In all thy ways acknowledge him, " +
                      "and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish.");

            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }

        Console.Clear();

        if (scripture.IsCompletelyHidden())
        {
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Congratulations! You memorized the scripture!");
        }
    }
}

