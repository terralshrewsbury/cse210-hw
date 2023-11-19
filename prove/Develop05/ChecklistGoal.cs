class ChecklistGoal:Goal
{       
    private int _partialComplete;
    private int _completeNumber;
    private int _bonusPoints;
    new private string _goalType = "Checklist Goal";

    public override string GoalSentence()
    {
        string _complete;
        if (_isComplete== false)
            { _complete = "[]";}
        else
            { _complete = "[X]";}
        return $"{_complete} {_goalName} ({_goalDiscription}) -- Currently {_partialComplete}/{_completeNumber} completed.";
    }
    public override string GoalSave()
    {
        return $"{_goalType}|{_goalName}|{_goalDiscription}|{_goalPoints}|{_isComplete}|{_partialComplete}|{_completeNumber}|{_bonusPoints}";
    }
    public void SetBonusPoints(int bonusPoints)
    {
        _bonusPoints = bonusPoints;
    }
    public int GetBonusPoints()
    {
        return _bonusPoints;
    }
    public void SetCompleteNumber(int completeNumber ){
        _completeNumber = completeNumber ;
    }
    public int GetCompleteNumber()
    {
        return _completeNumber;
    }
    public override void SetPartialComplete(int partialComplete){
        _partialComplete = partialComplete;
    }
    public int GetPartialComplete()
    {
        return _partialComplete;
    }
}
