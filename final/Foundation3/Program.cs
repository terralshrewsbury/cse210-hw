using System;
using System.Net.WebSockets;
using System.Threading.Channels;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("606 W. 1300 N.", "Clinton", "Utah", "84015");
        Address address2 = new Address("4643 S. Citadel St.", "West Valley", "Utah", "84120");
        Address address3 = new Address("2006 Shepherd land", "Kaysville", "Utah", "543231");

        Lecture lecture = new Lecture("Ted Talk", "Birds aren't real", DateTime.Now.AddDays(7), new TimeSpan(14, 0, 0), address1, "Lillie Shrewsbury", 150);
        Reception reception = new Reception("Wedding","Emmerie Brown & Travis Murphy",DateTime.Now.AddDays(33), new TimeSpan(18,30,0), address3, "ChuckBrown1@hotmail.com");
        Outdoor outdoor = new Outdoor("Sledding", "Sled and drink hot cocoa", DateTime.Now.AddDays(14), new TimeSpan(12,0,0), address2, "100% Chance of Snow");

        Console.WriteLine("Standard Details:\n");
        Console.WriteLine(lecture.GenerateStandardDetails());
        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine(reception.GenerateStandardDetails());
        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine(outdoor.GenerateStandardDetails());

        Console.WriteLine("\n\nFull Details \n");
        Console.WriteLine(lecture.GenerateFullDetails());
        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine(reception.GenerateFullDetails());
        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine(outdoor.GenerateFullDetails());

        Console.WriteLine("\n\nShort Descriptions: \n");
        Console.WriteLine(lecture.GenerateShortDescription());
        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine(reception.GenerateShortDescription());
        Console.WriteLine("\n-------------------------------------------\n");
        Console.WriteLine(outdoor.GenerateShortDescription());
    }
}
