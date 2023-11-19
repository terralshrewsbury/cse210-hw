using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using System.IO;
using System.Diagnostics.Tracing;


class Goal
{
    protected bool _isComplete;
    protected string _goalType;
    protected string _goalName;
    protected string _goalDiscription;
    protected int _goalPoints;

    public virtual string GoalSave()
    {
        return $"{_goalType}|{_goalName}|{_goalDiscription}|{_goalPoints}|{_isComplete}";
    }
    public virtual string GoalSentence()
    {
        string _complete;
        if (_isComplete== false)
            { _complete = "[]";}
        else
            { _complete = "[X]";}
        return $"{_complete} {_goalName} ({_goalDiscription})";
    }
    
    public void SetGoalName(string goalName)
    {
        _goalName = goalName;
    }
    public string GetGoalName()
    {
        return _goalName;
    }
    public void SetGoalDiscription(string goalDiscription)
    {
        _goalDiscription = goalDiscription;
    }
    public string GetGoalDiscription()
    {
        return _goalDiscription;
    }
    public virtual void SetGoalPoints(int goalPoints)
    {
        _goalPoints = goalPoints;
    }
    public virtual int GetGoalPoints()
    {
        return _goalPoints;
    }
    public void SetIsComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public bool GetIsComplete ()
    {
        return _isComplete;
    }

    public virtual void SetPartialComplete(int partialComplete)
    {
        int _partialComplete = partialComplete;
    }


    

}
