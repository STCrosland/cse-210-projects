
using System;
using System.Collections.Generic;

public class GratitudeActivity : Activity
{
    private List<string> _gratitudeItems = new List<string>();

    public GratitudeActivity()
        : base("Gratitude Activity",
               "This activity will help you focus on positive things in your life. Think about the people, experiences, and opportunities you are grateful for.")
    {
    }

    public void Run()
    {
        StartActivity();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine();
        Console.WriteLine("Write down something you are grateful for.");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");

            string answer = Console.ReadLine();

            if (DateTime.Now < endTime && !string.IsNullOrWhiteSpace(answer))
            {
                _gratitudeItems.Add(answer);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Your gratitude list:");

        foreach (string item in _gratitudeItems)
        {
            Console.WriteLine($"- {item}");
        }

        Console.WriteLine();
        Console.WriteLine($"You recorded {_gratitudeItems.Count} things you are grateful for.");

        EndActivity();
    }
}
