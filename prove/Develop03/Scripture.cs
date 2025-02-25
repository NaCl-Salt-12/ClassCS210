using System.Collections.Concurrent;
using Microsoft.Data.Sqlite;
using System.Linq;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, List<Word> words)
    {
        // scripture constructor that takes a reference and a list of words.
        _reference = reference;
        _words = words;
    }
    public Scripture(Reference reference)
    {
        // I have pervious expericne with SQLite so I will used it to get the scripture text.
        // and I looked up the C# documentation for the SQLite library.
        // This creates a connection to the SQLite database and gets the scripture text for the reference.
        _reference = reference;
        using var connection = new SqliteConnection("Data Source=./lds-scriptures-sqlite.db");
        connection.Open();
        var command = connection.CreateCommand();
        command.CommandText = 
            $"SELECT v.scripture_text FROM verses v JOIN chapters c ON c.id = v.chapter_id JOIN books b ON c.book_id = b.id WHERE (b.book_title = '{reference.GetBook()}' OR b.book_short_title = '{reference.GetBook()}') AND c.chapter_number = {reference.GetChapter()} AND v.verse_number >= {reference.GetStartVerse()} AND v.verse_number <= {reference.GetEndVerse()}";
        using var reader = command.ExecuteReader();
        string scriptureText = "";
        while (reader.Read())
        {
            scriptureText += reader.GetString(0) + " ";
        }
        scriptureText = scriptureText.Trim();
        _words = scriptureText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => new Word(word)).ToList();
        
    }
    public void HideRandomWords(int num)
    {
        // Get a list of words that are still visible.
        var visibleWords = _words.Where(w => !w.IsHidden()).ToList();
        System.Random random = new System.Random();
        for (int i = 0; i < num && visibleWords.Count > 0; i++)
        {
            int index = random.Next(visibleWords.Count);
            visibleWords[index].HideWord();
            visibleWords.RemoveAt(index);
        }
    }
    public string DisplayScriputure()
    {
        // Display the scripture with the words hidden.
        string scripture = _reference.GetRefrence() + "\n";
        foreach (Word word in _words)
        {
            scripture += word.GetWord() + " ";
        }
        return scripture;
    }
    public Boolean IsAllHidden()
    {
        // checks if all the words are hidden.
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}