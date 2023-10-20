using System.Collections.Generic;
using System;

public class Scripture
{
    private List<Word> _words;
    private Word _hiddenWord;
    private int _wordCount=0;
    private int _changedwordCount=0;
    
    public Scripture (string text)
    {
        _words = new List<Word>();
        string [] words = text.Split(' ');
        foreach (string word in words)
        {
            _wordCount ++;
            _words.Add(new Word(word));
        }  
    }

    public void Hide()
        {   
            if(_wordCount != _changedwordCount )
            {
                //Randomly select a word from the sentence.
                Random random = new Random();
                int index = random.Next(_words.Count);
                _hiddenWord = _words[index];

                if (_hiddenWord.GetIsHidden())
                {
                    do
                    {
                        index=random.Next(_words.Count);
                        _hiddenWord = _words[index];
                    }while(_hiddenWord.GetIsHidden());
                } 
               
                _words[index].SetText(Word.ReplaceCharacters(_hiddenWord));
                _hiddenWord.SetIsHidden(true);
                _changedwordCount ++;
            }
            
            else
            { 
                Console.WriteLine("You've hid all the words,\nPlease type quit.\nThank you Come Again!");
            }
        }
    
    public override string ToString()
    {
        string wordString = string.Join(" ", _words.Select(word => word.GetText()));
        return wordString;
    }
}
