using System.Reflection.Metadata.Ecma335;
using System.Threading;

public class Breathing : Activity
{
    private string _activity = "Breathing";
    private string _discription = "walking you through breathing in and out slowly. Clear your mind and focus on your breathing";
    
    public void RunBreathingActivity()
    {
        Console.Clear();
        Console.WriteLine(DisplayStartMessage(_activity, _discription));
        Console.WriteLine("");
        PauseAnimation(2000);
        int _standardDuration = AquireStandardDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAnimation(2000);
        DateTime _futureTime = SetStartTime(_standardDuration);
        Console.WriteLine("");
        do
        {   
            BreatheIn();
            Hold();
            BreatheOut();
            Console.WriteLine("");
        } while(LengthOfActivity(_futureTime) == true);
        PauseAnimation(3000);
        Console.WriteLine(DisplayEndMessage(_activity,_standardDuration));
        Console.WriteLine("");
        PauseAnimation(5000);
        Console.Clear();
    }

    public void BreatheIn()
    {
        Console.Write("Breathe In... ");
        PauseCountdown(3000);
    }

    public void Hold()
    {
        Console.Write("Hold... ");
        PauseCountdown(3000);
    }

     public void BreatheOut()
    {
        Console.Write("Breathe out... ");
        PauseCountdown(3000);    
    }
}