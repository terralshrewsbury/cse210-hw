public class Word
{
    private string _text;
    private bool _isHidden {get; set;}

    public Word(string text)
    {
        if(text.Contains("_"))
        {
            _isHidden = true;
        } 
        else
        {
            _isHidden = false;
        }
        _text = text;
    }

   public void SetIsHidden(bool IsHidden)
   {
        _isHidden = IsHidden;
   }

    public bool GetIsHidden()
    {
        return _isHidden;
    }

    public string GetText()
    {
        return _text;
    }

    public void SetText(string newText)
    {
        _text = newText;
    }

   public static string ReplaceCharacters(Word  hiddenWord)
    {
        //Replace characters of hidden word with underscores
        string hiddenwordContent = hiddenWord._text;
        string hiddenWordWithUnderscores = new string ('_', hiddenwordContent.Length);
        return hiddenWordWithUnderscores;
    }
 
}
