
using System;
using System.Threading;

public class Activity
{
    // Private member variables
    private string _name;
    private string _description;
    private int _duration;

    // Constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _duration = 0;
    }

    // Getters
    public int GetDuration()
    {
        return _duration;
    }

    public string GetName()
    {
        return _name;
    }

    // Starting message shared by all activities
    public void StartActivity()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
    }

    // Ending message shared by all activities
    public void EndActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");

        ShowSpinner(3);
    }

    // Spinner animation
    public void ShowSpinner(int seconds)
    {
        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        char[] spinner = { '|', '/', '-', '\\' };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            index = (index + 1) % spinner.Length;
        }
    }

    // Countdown animation
    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
