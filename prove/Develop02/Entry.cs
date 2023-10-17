using System;


public class Entry
{
    public string _promptResponse = "";
    public string _getDate = "";
    public string _entry = "";

    public string GetPromptResponse()
    {
        WritingPrompts writingPrompts = new WritingPrompts();
        writingPrompts.Prompts();
        string promptChoice = writingPrompts.GetPromptChoice();
        Console.WriteLine(promptChoice);

        DateTime theCurrentTime = DateTime.Now;
        _getDate = theCurrentTime.ToShortDateString();

        _promptResponse = Console.ReadLine();

        _entry = _getDate + (":") + _promptResponse + (";");

        return _entry;
    
    }
}


