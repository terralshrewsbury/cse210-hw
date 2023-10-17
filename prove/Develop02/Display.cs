using System;
using System.IO.Enumeration;

public class Display
{
    public void DisplayJournalFile()
    {
        string filename = "journalFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(";");
            string concatenatedString = string.Join(" ", parts);
                Console.WriteLine(concatenatedString);
        }           
    }
}


