using System;

class ChecklistGoal : Goal
{
    protected int _goalBonus;
    protected int _ntimes;
    protected int _rtimes;
    public override void GoalEntrySpecific()
    {
        base.GoalEntryBase();
        Console.WriteLine("How many times do you want this goal to be accomplished for a bonus? ");
        _ntimes = int.Parse(Console.ReadLine());
        Console.WriteLine("How much is the bonus? ");
        _goalBonus = int.Parse(Console.ReadLine());
    }
    public void SetLoadValues(string name, string description, int points, int bonus, int ntimes, int rtimes)
    {
        _goalName = name;
        _goalDescription = description;
        _goalPoint = points;
        _goalBonus = bonus;
        _ntimes = ntimes;
        _rtimes = rtimes;
    }
    public override int StatusUpdate()
    {
        ++_rtimes;
        return _rtimes;
    }


    public override void Complete()
    {
        if (_ntimes==_rtimes||_rtimes>_ntimes)
        {
            _completion = true;
        }
        else _completion = false;
    }

    public override int GetBonus()
    {
        return _goalBonus;
    }


    public override string GetStringRepresentation()
    {
        
        string simple = $"{_goalType}:{_goalName}~~{_goalDescription}~~{_goalPoint}~~{_goalBonus}~~{_ntimes}~~{_rtimes}";
        return simple;
    }
    
    public override string DisplayGoal()
    {
        return ($"{_goalName} ({_goalDescription}) -- Currently completed: {_rtimes}/{_ntimes}");
    }

}