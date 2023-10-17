using System.Collections.Generic;
using System;

public class WritingPrompts
{
    private List <string> writingPrompts = new List <string> ();
    private string promptChoice;
    
    public void Prompts()
    {
    writingPrompts.Add("List five things you are grateful for today.");
    writingPrompts.Add("Write about a person in your life for whom you are grateful and why.");
    writingPrompts.Add("Reflect on a difficult experience you have had and identify one thing you learned from it that you are grateful for.");
    writingPrompts.Add("Write about a challenge you are currently facing and identify one thing you are grateful for that has helped you cope.");
    writingPrompts.Add("Make a list of ten things you are grateful for in your home.");
    writingPrompts.Add("Write about a place you are grateful to have visited or experienced.");
    writingPrompts.Add("List three things that brought a smile to your face today and write about why they made you happy.");
    writingPrompts.Add("Write a letter of gratitude to someone who has had a positive impact on your life.");
    writingPrompts.Add("Make a list of five things you are grateful for about your body.");
    writingPrompts.Add("Write about a time in your life when you received unexpected kindness and how it made you feel.");
    writingPrompts.Add("List three things you are grateful for about your job or career.");
    writingPrompts.Add("Write about a friend or family member who has supported you through a difficult time and why you are grateful for them.");
    writingPrompts.Add("Make a list of five things you are grateful for in nature.");
    writingPrompts.Add("Write about a skill or talent you possess that you are grateful for.");
    writingPrompts.Add("List three things you are grateful for about your physical health.");
    
    Random random = new Random();
    int index = random.Next(writingPrompts.Count);
    promptChoice = writingPrompts[index];  
    }

    public string GetPromptChoice()
    {
        return promptChoice;
    }

}

