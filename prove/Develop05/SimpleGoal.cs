using System;

class SimpleGoal : Goal
{

    public override void GoalEntrySpecific()
    {
        base.GoalEntryBase();
    }

    public void SetLoadValues(string name, string description, int points, Boolean completion)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoint = points;
        _completion = completion;
    }


    public override string GetStringRepresentation()
    {
        string simple = $"{_goalType}:{_goalName}~~{_goalDescription}~~{_goalPoint}~~{_completion}";
        return simple;
    }
    public override string DisplayGoal()
    {
        return ($"{_goalName} ({_goalDescription})");
    }
}