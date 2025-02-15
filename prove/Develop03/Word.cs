using System.Runtime.CompilerServices;

public class Word{
   private string _word;
   private bool _isHidden;

    public Word(string word)
    {
         _word = word;
         _isHidden = false;
    }
    public string GetWord()
    {
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
        _isHidden = false;
    }
    public void HideWord()
    {
        _isHidden = true;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }

}