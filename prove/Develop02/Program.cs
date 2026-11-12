using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity beyond the core requirements:
        // This journal records the time and a mood rating for each entry.
        // It also includes extra prompts, displays the entry count, and
        // uses JSON storage so commas and quotation marks are preserved.

        Journal journal = new Journal();

        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is something new I learned today?",
            "What is one thing I am grateful for right now?",
            "What is a goal I made progress toward today?",
            "What made me laugh or smile today?",
            "What is one thing I want to remember about today?"
        };

        Random random = new Random();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to the Journal Program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    string prompt = prompts[random.Next(prompts.Count)];

                    Console.WriteLine();
                    Console.WriteLine(prompt);
                    Console.Write("> ");

                    string response = Console.ReadLine();

                    Console.Write("How would you rate your mood today (1-5)? ");
                    string moodInput = Console.ReadLine();
                    int mood;

                    while (!int.TryParse(moodInput, out mood) ||
                           mood < 1 || mood > 5)
                    {
                        Console.Write("Please enter a number from 1 to 5: ");
                        moodInput = Console.ReadLine();
                    }

                    string date = DateTime.Now.ToString("g");

                    Entry newEntry = new Entry(date, prompt, response, mood);
                    journal.AddEntry(newEntry);

                    Console.WriteLine("Your entry has been saved to the journal.");
                    break;

                case "2":
                    journal.DisplayEntries();
                    break;

                case "3":
                    Console.Write("What is the filename you want to load? ");
                    string loadFilename = Console.ReadLine();

                    try
                    {
                        journal.LoadFromFile(loadFilename);
                        Console.WriteLine("Journal loaded successfully.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The journal could not be loaded. Check the filename and try again.");
                    }
                    break;

                case "4":
                    Console.Write("What is the filename you want to save as? ");
                    string saveFilename = Console.ReadLine();

                    try
                    {
                        journal.SaveToFile(saveFilename);
                        Console.WriteLine("Journal saved successfully.");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("The journal could not be saved. Check the filename and try again.");
                    }
                    break;

                case "5":
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Please enter a number from 1 to 5.");
                    break;
            }
        }
    }
}