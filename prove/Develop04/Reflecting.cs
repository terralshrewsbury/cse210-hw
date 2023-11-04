using System.Diagnostics.CodeAnalysis;

public class Reflecting : Activity
{
    private List<string> _prompts= new List<string>();
    private List<string> _usedPrompts= new List<string>();
    private List<string> _questions = new List<string>();
    private List<string> _usedQuestions = new List<string>();
    private string _activity = "Reflecting";
    private string _discription = "reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    
    private void AddToList()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    public void RunReflectingActivity()
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
        Console.WriteLine("Consider the following prompt:");
        string _randomprompt= GetRandomUnseenQuestionOrPrompt(_prompts,_usedPrompts);
        Console.WriteLine($"---{_randomprompt}---");
        PauseAnimation(2000);
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("Now Ponder on each of the following questions as they relate to this experience.");
        Console.WriteLine("You may begin in:");
        PauseCountdown(3000);
        Console.Clear();
        do
        {
            string _randomQuestion = GetRandomUnseenQuestionOrPrompt(_questions, _usedQuestions);
            Console.WriteLine ($"> {_randomQuestion}");
            PauseAnimation(5000); 
        }while (LengthOfActivity(_futureTime) == true);
        PauseAnimation(1000);
        Console.WriteLine("");
        Console.WriteLine(DisplayEndMessage(_activity,_standardDuration));
        Console.WriteLine("");
        PauseAnimation(5000);
        Console.Clear();
    }
}