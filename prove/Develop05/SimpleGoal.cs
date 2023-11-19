class SimpleGoal:Goal 
{
    new private string _goalType = "Simple Goal";
    public override string GoalSentence()
    {
        return base.GoalSentence();
    }
    public override string GoalSave()
     {
        return $"{_goalType}|{_goalName}|{_goalDiscription}|{_goalPoints}|{_isComplete}";
    }
}
