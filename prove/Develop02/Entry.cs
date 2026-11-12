using System;

class Entry
{
    // Member variables store information about one journal entry.
    private string _date;
    private string _prompt;
    private string _response;
    private int _mood;

    public Entry()
    {
        // Allows the JSON serializer to create an Entry when loading.
    }

    public Entry(string date, string prompt, string response, int mood)
    {
        _date = date;
        _prompt = prompt;
        _response = response;
        _mood = mood;
    }

    // Properties allow the serializer to save and load entry information.
    public string Date
    {
        get { return _date; }
        set { _date = value; }
    }

    public string Prompt
    {
        get { return _prompt; }
        set { _prompt = value; }
    }

    public string Response
    {
        get { return _response; }
        set { _response = value; }
    }

    public int Mood
    {
        get { return _mood; }
        set { _mood = value; }
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine($"Mood: {_mood}/5");
        Console.WriteLine("-----------------------------------");
    }
}