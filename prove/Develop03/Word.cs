using System.Runtime.CompilerServices;

public class Word{
   private string _word;
   private bool _isHidden;

    public Word(string word)
    {
        // A constructor that takes a word.
         _word = word;
         _isHidden = false;
    }
    public string GetWord()
    {
        // Returns the word if it is not hidden, otherwise returns a string of asterisks the same length as the word.
        if (_isHidden)
        {
            return new string('*', _word.Length);
        }
        else
        {
            return _word;
        }
    }
    public void ShowWord()
    {
        // Shows the word.
        _isHidden = false;
    }
    public void HideWord()
    {
        // Hides the word.
        _isHidden = true;
    }
    public bool IsHidden()
    {
        // Returns true if the word is hidden, otherwise returns false.
        return _isHidden;
    }

}