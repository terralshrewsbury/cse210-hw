class EternalGoal:Goal
{
    new private string _goalType = "Eternal Goal";
    public override string GoalSentence()
    {
        string _complete;
        if (_isComplete== false)
            { _complete = "[]";}
        else
            { _complete = "[]";}
        return $"{_complete} {_goalName} ({_goalDiscription})";
    }
    public override string GoalSave()
    {
        return $"{_goalType}|{_goalName}|{_goalDiscription}|{_goalPoints}|{_isComplete}";
    }

}
