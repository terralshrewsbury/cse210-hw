using System;
using System.IO;



class Program
{
    static void Main(string[] args)
    {
        int _selection = 0;
        do
        {
            string _menu = "Please Select one of the following choices: \n1. Write\n2. Display\n3. Load\n4. Quit\nWhat would you like to do? ";
            string _choice = "";


            Console.WriteLine("Welcome to the Journal Program.");
            Console.WriteLine(_menu);
            _choice = Console.ReadLine();
            _selection = int.Parse(_choice);

            if (_selection == 1)
            {
                Entry entry = new Entry();
                string response = entry.GetPromptResponse();
                string filename = "journalFile.txt";
                using (StreamWriter outputFile = File.AppendText(filename))
                {
                outputFile.WriteLine(response);
                }
            }

            if (_selection == 2)
            {
                Display display = new Display();
                 display.DisplayJournalFile();
                

            }

            if (_selection == 3)
            {
                string filename = "journalFile.txt";
                if (File.Exists(filename))
                {
                    System.Diagnostics.Process.Start("cmd", $"/c start {filename}");
                }
                else
                {
                    Console.WriteLine("The journal file does not exist.");
                }
            }
            
            
        } while (_selection != 4);
        Console.WriteLine("Have a great day!");
    }   
} 

