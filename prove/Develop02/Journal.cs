using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Journal
{
    // Stores the complete list of journal entries.
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("Your journal is empty.");
            return;
        }

        Console.WriteLine();
        Console.WriteLine($"Journal Entries: {_entries.Count}");
        Console.WriteLine("-----------------------------------");

        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        string json = JsonSerializer.Serialize(
            _entries,
            new JsonSerializerOptions { WriteIndented = true }
        );

        File.WriteAllText(filename, json);
    }

    public void LoadFromFile(string filename)
    {
        string json = File.ReadAllText(filename);

        List<Entry> loadedEntries =
            JsonSerializer.Deserialize<List<Entry>>(json);

        if (loadedEntries == null)
        {
            _entries = new List<Entry>();
        }
        else
        {
            // Loading replaces the entries currently in the journal.
            _entries = loadedEntries;
        }
    }
}