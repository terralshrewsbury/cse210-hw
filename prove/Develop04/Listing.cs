public class Listing : Activity
{
    private List<string> _prompts= new List<string>();
    private List<string> _usedPrompts= new List<string>();
    private string _activity = "Listing";
    private string _discription = "reflect on the good things in your life by having you list as many things as you can in a certain area";
    private int _count = 0;
    
    private void AddToList()
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void RunListingActivity()
    {
        Console.Clear();
        Console.WriteLine(DisplayStartMessage(_activity,_discription));
        Console.WriteLine("");
        PauseAnimation(2000);
        int _standardDuration = AquireStandardDuration();
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseAnimation(2000);
        Console.WriteLine("");
        DateTime _futureTime = SetStartTime(_standardDuration);
        AddToList();
        Console.WriteLine("List as many responses you can to the following prompt:");
        string _randomPrompt = GetRandomUnseenQuestionOrPrompt(_prompts, _usedPrompts);
        Console.WriteLine($"---{_randomPrompt}---");
        Console.WriteLine("You may begin in: ");
        PauseCountdown(3000);
        do
        {
            Console.Write(">");
            Console.ReadLine();
            _count ++;
        }while (LengthOfActivity(_futureTime) == true);
        PauseAnimation(1000);
        Console.WriteLine($"You listed {_count} items!");
        Console.WriteLine("");
        Console.WriteLine(DisplayEndMessage(_activity,_standardDuration));
        Console.WriteLine("");
        PauseAnimation(5000);
        Console.Clear();  
    }

}