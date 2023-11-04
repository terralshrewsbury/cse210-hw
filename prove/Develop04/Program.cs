using System;
using System.Diagnostics.Contracts;
using System.Threading;

class Program
{
    
    static void Main(string[] args)
    {
        Console.Clear();
        string _input="";
        int _count = 0;
        do
        {
            _count ++;
            Console.WriteLine("-----Mindfulness Activities-----");
            Console.WriteLine("Menu Options: \n  1. Start breathing activity \n  2. Start reflecting activity \n  3. Start listing activity \n  4. Quit \nSelect a choice from the menu: ");
            _input = Console.ReadLine();
            if (_input == "1")
            {
                Breathing breathing = new Breathing();
                breathing.RunBreathingActivity();
            }
            if(_input == "2")
            {
                Reflecting reflecting = new Reflecting();
                reflecting.RunReflectingActivity();
            }
            if(_input == "3")
            {
                Listing listing = new Listing();
                listing.RunListingActivity();
            }
        } while(_input != "4");
        Console.WriteLine($"You completed {_count} mindfulness activities. \nI hope it has lightened your day! ");
    }   
}