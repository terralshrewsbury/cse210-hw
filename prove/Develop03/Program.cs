using System;


class Program
{
    static void Main(string[] args)
    {
       ScriptureLibrary scripturelibrary = new ScriptureLibrary();
       string passage = scripturelibrary.GetScripture();
       string [] passageParts = passage.Split(";");
       string referance = passageParts[0].Trim();
       string text = passageParts[1].Trim();

       ScriptureReference scriptureReference = new ScriptureReference(referance);
       Scripture scripture = new Scripture(text);

       Console.Clear();
       Console.WriteLine("Welcome to Scripture Memorizer \nPress Enter to hide a word, and type quit to exit.");
       Console.WriteLine($"Scripture Reference: {scriptureReference.referanceAsString()}");
       string input = Console.ReadLine();
       while (input != "quit")
       {
            Console.Clear();
            Console.WriteLine("Press Enter to hide a word, and type quit to exit.\n");
            Console.WriteLine($"{scriptureReference.referanceAsString()}; {scripture.ToString()}");
            if (input == "")
            {
                scripture.Hide();
                input = Console.ReadLine();
            }
       }

    }
}