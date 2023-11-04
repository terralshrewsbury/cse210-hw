using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
public class Activity 
{
    private int _standardDuration;
    private string _activity;
    private string _discriptionOfActivity;
    private List<string> _prompts;
    private string _randomPrompt;
    private Random _random = new Random();
    
    
    protected string DisplayStartMessage(string activity, string discription)
    {
        _activity = activity;
        _discriptionOfActivity = discription;

        string _displayStartMessage = $"Welcome to the {_activity} Activity. \nThis activity will help you relax by {_discriptionOfActivity}.";
        return _displayStartMessage;
    }

    public int AquireStandardDuration()
    {
        Console.WriteLine("How long, in seconds would you like for your session?");
        string _duration = Console.ReadLine();
        if (int.TryParse(_duration, out int _intDuration))
        {
            return _intDuration;
        }
        else
        {
            Console.WriteLine("Invalid input. Default is 30 seconds.");
            return 30;
        }
    }

    protected string DisplayEndMessage(string activity, int duration)
    {
        _activity=activity;
        _standardDuration=duration;

    
        string _displayEndMessage = $"Well done!! \nYou have completed {_standardDuration} seconds of the {_activity} Activity."; 
        return _displayEndMessage;
    }

    protected void PauseAnimation(int _milliseconds)
    {
        for (int i=_milliseconds/1000; i>0; i--)
        {
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("\\");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("|");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("/");
            Thread.Sleep(250);
            Console.Write("\b\b");
            Console.Write("-");
            Thread.Sleep(250);
            Console.Write("\b\b");
                        
        }
        
    }

    public void PauseCountdown(int _milliseconds)
    {
        for (int i= _milliseconds/1000; i>0; i--)
        {
            Console.Write(i);
            Thread.Sleep(_milliseconds);
            Console.Write("\b \b");
        }
        Console.WriteLine("");
    }

    protected DateTime SetStartTime(int duration)
    {
         _standardDuration=duration;
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_standardDuration);
        return futureTime;
    }

    protected bool LengthOfActivity (DateTime futureTime)
    {
        DateTime _futureTime = futureTime;
        DateTime currentTime = DateTime.Now;
        
        if (currentTime < _futureTime)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    public string RandomPromptGenerator(List<string> prompts)
    {
        _prompts = prompts;
        Random random = new Random();
        int i = random.Next(_prompts.Count);
        _randomPrompt = _prompts[i];
        
        return _randomPrompt;
    }

    public string GetRandomUnseenQuestionOrPrompt(List<string> _questions, List<string> _usedQuestions)
    {
        
        List<string> filteredQuestions = _questions.Except(_usedQuestions).ToList();
        if (filteredQuestions.Count == 0)
        {
            _usedQuestions.Clear();
            filteredQuestions = _questions.ToList();
        }
        int index = _random.Next(filteredQuestions.Count);
        string randomQuestion = filteredQuestions[index];
        _usedQuestions.Add(randomQuestion);
        return randomQuestion;
    }
}

