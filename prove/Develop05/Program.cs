using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;

List<Goal> goals = new List<Goal>();
int _currentpoints = 0;
int _menuSelection = 0;
string _fileName;

static void DisplayMenu()
{
    Console.WriteLine("1. Create New Goal");
    Console.WriteLine("2. List Goal");
    Console.WriteLine("3. Save Goals");
    Console.WriteLine("4. load Goals");
    Console.WriteLine("5. Record Event");
    Console.WriteLine("6. Quit");
}
Console.WriteLine("Welcome to the Goal Game!\nHow many points can you get. Beat your friends.");
do
{
    
    Console.WriteLine($"\nYour current points: {_currentpoints} \n");
    DisplayMenu();
    Console.WriteLine("Select a choice from the menu: ");
    PauseAnimation(1000);
    _menuSelection = int.Parse(Console.ReadLine());
    ChecklistGoal checklistGoal = null;

    switch (_menuSelection)
    {
        case 1:
            Console.Clear();
            Console.WriteLine("Welcome to Goal setting!");
            Console.WriteLine("What goal would you like to set?");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.WriteLine("Select a Choice from the Menu: ");
            PauseAnimation(2000);
            int _goalMenuSelection = int.Parse(Console.ReadLine());

            switch (_goalMenuSelection)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine("What would you like to name this goal?");
                    PauseAnimation(1000);
                    string goalName = Console.ReadLine();
                    SimpleGoal simpleGoal = new SimpleGoal();
                    simpleGoal.SetGoalName(goalName);
                    Console.WriteLine("How do you acomplish this goal?");
                    PauseAnimation(2000);
                    string goalDiscription = Console.ReadLine();
                    simpleGoal.SetGoalDiscription(goalDiscription);
                    Console.WriteLine("How many points would you like this goal to be worth?");
                    PauseAnimation(2000);
                    int goalPoints = Convert.ToInt32(Console.ReadLine());
                    simpleGoal.SetGoalPoints(goalPoints);
                    goals.Add(simpleGoal);
                    PauseAnimation(2000);
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("What would you like to name this goal?");
                    PauseAnimation(1000);
                    string eternalName = Console.ReadLine();
                    EternalGoal eternalGoal = new EternalGoal();
                    eternalGoal.SetGoalName(eternalName);
                    Console.WriteLine("How do you acomplish this goal?");
                    PauseAnimation(2000);
                    string eternalDiscription = Console.ReadLine();
                    eternalGoal.SetGoalDiscription(eternalDiscription);
                    Console.WriteLine("How many points would you like this goal to be worth each time you do it?");
                    PauseAnimation(2000);
                    int eternalPoints = Convert.ToInt32(Console.ReadLine());
                    eternalGoal.SetGoalPoints(eternalPoints);
                    goals.Add(eternalGoal);
                    PauseAnimation(2000);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("What would you like to name this goal?");
                    PauseAnimation(1000);
                    string checklistName = Console.ReadLine();
                    checklistGoal = new ChecklistGoal();
                    checklistGoal.SetGoalName(checklistName);
                    Console.WriteLine("How do you acomplish this goal?");
                    PauseAnimation(2000);
                    string checklistDiscription = Console.ReadLine();
                    checklistGoal.SetGoalDiscription(checklistDiscription);
                    Console.WriteLine("How many points would you like this goal to be worth each time accomplished?");
                    PauseAnimation(2000);
                    int checklistPoints = Convert.ToInt32(Console.ReadLine());
                    checklistGoal.SetGoalPoints(checklistPoints);
                    Console.WriteLine("How many times would you like to do this task before it is completed?");
                    PauseAnimation(2000);
                    int checklistCompleteNumber = Convert.ToInt32(Console.ReadLine());
                    checklistGoal.SetCompleteNumber(checklistCompleteNumber);
                    Console.WriteLine("How many points would you like this goal to be worth after accomplishing it all?");
                    PauseAnimation(2000);
                    int checklistBonusPoints = Convert.ToInt32(Console.ReadLine());
                    checklistGoal.SetBonusPoints(checklistBonusPoints);
                    goals.Add(checklistGoal);
                    PauseAnimation(2000);
                    break;
                default:
                    Console.WriteLine("Invalid goal Selection Please try again.");
                    PauseAnimation(3000);
                    break;
            }
            Console.Clear();
            break;
        case 2:
            Console.Clear();
            //List goals
            int _count = 0;
            foreach (Goal goal in goals)
            {
                _count += 1;
                Console.WriteLine($"{_count}. {goal.GoalSentence()}");
                PauseAnimation(1000);
            }
            break;
        case 3:
            // Save Goals
            Console.Clear();
            Console.WriteLine("What would you like to name the file you save your goals to?");
            _fileName = Console.ReadLine();
            using (StreamWriter outputFile = File.AppendText(_fileName))
            {
                foreach (Goal goal in goals)
                {
                    outputFile.WriteLine(goal.GoalSave());
                }
            }
            Console.WriteLine($"Your Goals have been saved as {_fileName}.");
            goals.Clear();
                break;
        case 4:
            // Load Goals
            Console.WriteLine("What is the name of the file you wish to load from?");
            _fileName = Console.ReadLine();
            if (File.Exists(_fileName))
            {
                string[] lines = File.ReadAllLines(_fileName);
                foreach (string line in lines)
                {
                    Goal goal = ParseGoalFromString(line);
                    if (goal != null)
                    {
                        goals.Add(goal);
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing goal from line: {line}");
                    }
                }
            }
            else
            {
                Console.WriteLine("The file does not exist.");
            }
            break;
        case 5:
            // Record Event
            
            Console.WriteLine("What goal would you like to record an acheivment with?");
            _count = 0;
            foreach (Goal goal in goals)
            {
                _count += 1;
                Console.WriteLine($"{_count}. {goal.GoalSentence()}");
                PauseAnimation(1000);
            }
            int _pickAGoal = int.Parse(Console.ReadLine());
            
            if (_pickAGoal >= 1 && _pickAGoal <= goals.Count)
            {
                Goal selectedGoal = goals[_pickAGoal-1];
                if (selectedGoal is SimpleGoal)
                {
                    Console.WriteLine($"Recording achievemnet for Simple Goal: {selectedGoal.GetGoalName()}");
                    Console.WriteLine("Did you accomplish this goal?");
                    string _answer = Console.ReadLine();
                    if (_answer == "yes")
                    {
                        selectedGoal.SetIsComplete(true);
                        _currentpoints += selectedGoal.GetGoalPoints();
                    }
                    else 
                    {
                        Console.WriteLine("Keep trying");
                    }
                }
                else if (selectedGoal is EternalGoal)
                {
                    Console.WriteLine($"Recording achievemnet for Eternal Goal: {selectedGoal.GetGoalName()}");
                    Console.WriteLine($"Did you {selectedGoal.GetGoalDiscription()}");
                    string _eternalAnswer = Console.ReadLine();
                    if (_eternalAnswer == "yes")
                    {
                        _currentpoints += selectedGoal.GetGoalPoints();
                        Console.WriteLine($"Everytime you achive this goal you will get {selectedGoal.GetGoalPoints()}.");
                    }
                    else
                    {
                        Console.WriteLine("If at first you don't succsed, Try Try Again.");
                    }
                }
                else if (selectedGoal is ChecklistGoal)
                {
                    Console.WriteLine($"Recording achievemnet for Eternal Goal: {selectedGoal.GetGoalName()}");
                    Console.WriteLine($"Did you {selectedGoal.GetGoalDiscription()}");
                    string _checklistAnswer = Console.ReadLine();
                    if (_checklistAnswer == "yes")
                    {
                        
                        Console.WriteLine($"How many times have you {selectedGoal.GetGoalDiscription()}");
                        int _amountOfTimes = int.Parse(Console.ReadLine());
                        _currentpoints += selectedGoal.GetGoalPoints()*_amountOfTimes;
                        selectedGoal.SetPartialComplete(_amountOfTimes);
                        int _completed = checklistGoal.GetCompleteNumber();
                        if (_amountOfTimes == _completed)
                        {
                            selectedGoal.SetIsComplete(true);
                        }
                    }
                    else
                    {
                        Console.WriteLine("If at first you don't succsed, Try Try Again.");
                    }
                }
            }
            break;
        case 6:
            // Quit
            break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }

} while (_menuSelection != 6);
Console.WriteLine("Thank You for Setting Goals with Us today.\nFollow up with you later!");


void PauseAnimation(int _milliseconds)
{
    for (int i = _milliseconds / 1000; i > 0; i--)
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
static Goal ParseGoalFromString(string goalstring)
{
    string[] goalComponents = goalstring.Split("|");

    string goalType = goalComponents[0].Trim();
    string goalName = goalComponents[1].Trim();
    string goalDescription = goalComponents[2].Trim();
    int goalPoints = int.Parse(goalComponents[3].Trim());
    bool isComplete = bool.Parse(goalComponents[4].Trim());

    // Create the appropriate goal object based on the goalType
    switch (goalType)
    {
        case "Simple Goal":
            SimpleGoal simpleGoal = new SimpleGoal();
            simpleGoal.SetGoalName(goalName);
            simpleGoal.SetGoalDiscription(goalDescription);
            simpleGoal.SetGoalPoints(goalPoints);
            simpleGoal.SetIsComplete(isComplete);
            return simpleGoal;

        case "Eternal Goal":
            EternalGoal eternalGoal = new EternalGoal();
            eternalGoal.SetGoalName(goalName);
            eternalGoal.SetGoalDiscription(goalDescription);
            eternalGoal.SetGoalPoints(goalPoints);
            eternalGoal.SetIsComplete(isComplete);
            return eternalGoal;

        case "Checklist Goal":
            // Extract additional properties specific to ChecklistGoal and create the object
            int partialComplete = int.Parse(goalComponents[5].Trim());
            int completeNumber = int.Parse(goalComponents[6].Trim());
            int bonusPoints = int.Parse(goalComponents[7].Trim());

            ChecklistGoal checklistGoal = new ChecklistGoal();
            checklistGoal.SetGoalName(goalName);
            checklistGoal.SetGoalDiscription(goalDescription);
            checklistGoal.SetGoalPoints(goalPoints);
            checklistGoal.SetIsComplete(isComplete);
            checklistGoal.SetPartialComplete(partialComplete);
            checklistGoal.SetCompleteNumber(completeNumber);
            checklistGoal.SetBonusPoints(bonusPoints);
            return checklistGoal;

        default:
            // Handle unknown goal types or throw an exception
            throw new ArgumentException($"Unknown goal type: {goalType}");
    }
}


