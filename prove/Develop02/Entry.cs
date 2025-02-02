using System;

public class Entry
{
    private string _prompt;
    private string _text;
    private DateTime _date;

    public Entry(string text, DateTime date, string prompt)
    {
        // this.prompt = prompt;
        this._text = text;
        this._date = date;
        this._prompt =prompt;
    }
    public void Display()
    {
        Console.WriteLine($"{_date}: {_prompt} - {_text}");
    }
    public string Format()
    {
        return $"{_date},{_prompt},{_text}";
    }
}