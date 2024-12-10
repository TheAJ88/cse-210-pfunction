using System;

class EternalGoal : Goal
{
    public override void GoalEntrySpecific()
    {
        base.GoalEntryBase();
    }
    public void SetLoadValues(string name, string description, int points)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoint = points;
    }
    public override string GetStringRepresentation()
    {
        string simple = $"{_goalType}:{_goalName}~~{_goalDescription}~~{_goalPoint}";
        return simple;
    }
    public override string DisplayGoal()
    {
        return ($"{_goalName} ({_goalDescription})");
    }
}