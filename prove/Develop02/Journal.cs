using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Streamwriter = System.IO.StreamWriter;
public class Journal
{
    private List<Entry> _entries = new List<Entry>();

public void AddEntry(string text, string prompt)
{
    _entries.Add(new Entry(text, DateTime.Now, prompt));
}
    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }    
    
    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter("Journal.txt"))
        {
            foreach (var entry in _entries)
            {
                string line = entry.Format();
                writer.WriteLine(line);
            }
        }

    }
    public void LoadFromFile()
    {
        using (StreamReader reader = new StreamReader("Journal.txt"))
        {
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                string[] parts = line.Split(',');
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string text = parts[2];
                _entries.Add(new Entry(text, date, prompt));
            }
        }
    }
    public void DeleteJournalFile()
    {
        if (File.Exists("Journal.txt"))
        {
            File.Delete("Journal.txt");
        }
    }


}