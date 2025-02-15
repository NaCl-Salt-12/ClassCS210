public class Reference{

    private string _book;
    private int _chapter;
    private int _startverse;
    private int _endverse;

    public Reference(string book, int chapter, int startverse, int endverse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = startverse;
        _endverse = endverse;
    }
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startverse = verse;
        _endverse = verse;
    }
    public Reference(string reference)
    {
        // Split the input string into the book name and the chapter/verse part.
        int spaceIndex = reference.LastIndexOf(' ');
        if (spaceIndex == -1)
            throw new ArgumentException("Invalid reference format.");

        string bookPart = reference.Substring(0, spaceIndex);
        string chapterVersePart = reference.Substring(spaceIndex + 1);

        // Split the chapter from the verses.
        string[] parts = chapterVersePart.Split(':');
        if (parts.Length != 2)
            throw new ArgumentException("Invalid reference format.");

        if (!int.TryParse(parts[0], out _chapter))
            throw new ArgumentException("Invalid chapter number.");

        // Determine if a range or a single verse is provided.
        if (parts[1].Contains("-"))
        {
            string[] verses = parts[1].Split('-');
            if (verses.Length != 2)
                throw new ArgumentException("Invalid verses format.");

            if (!int.TryParse(verses[0], out _startverse))
                throw new ArgumentException("Invalid starting verse.");

            if (!int.TryParse(verses[1], out _endverse))
                throw new ArgumentException("Invalid ending verse.");
        }
        else
        {
            if (!int.TryParse(parts[1], out _startverse))
                throw new ArgumentException("Invalid verse number.");

            _endverse = _startverse;
        }

        _book = bookPart;
    }
    public string GetRefrence()
    {
        if (_startverse == _endverse)
        {
            return _book + " " + _chapter + ":" + _startverse;
        }
        else
        {
            return _book + " " + _chapter + ":" + _startverse + "-" + _endverse;
        }
    }
    public string GetBook()
    {
        return _book;
    }
    public int GetChapter()
    {
        return _chapter;
    }
    public int GetStartVerse()
    {
        return _startverse;
    }
    public int GetEndVerse()
    {
        return _endverse;
    }
}