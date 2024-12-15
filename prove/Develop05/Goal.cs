using System;

public class Goal
{
    protected string _goalType;
    protected string _type;
    protected string _goalName;
    protected string _goalDescription;
    protected int _goalPoint;
    protected Boolean _completion = false;


    public void GoalEntryBase()
    {
        Console.WriteLine("What is the name of this goal? ");
        _goalName = Console.ReadLine();
        Console.WriteLine("Give a short description of this goal? ");
        _goalDescription = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal? ");
        _goalPoint = int.Parse(Console.ReadLine());
    }

    public virtual void GoalEntrySpecific(){}
    
    public virtual int GetBonus()
    {
        return 0;
    }

    public Boolean GetCompletion()
    {
        return _completion;
    }

    public virtual void Complete()
    {
        _completion = true;
    }

    public void SetType(string goalType)
    {
        _goalType = goalType;
    }

    public string GetGoal()
    {
        return _goalType;
    }

    public virtual int StatusUpdate()
    {
        return 0;
    }

    public virtual int GetPoints()
    {
        return _goalPoint;
    }

    public void SetPoints(int points)
    {
        _goalPoint = points;
    }


    public virtual string DisplayGoal()
    {
        return ($"{_goalName}~~{_goalDescription}~~{_goalPoint}");
    }
   

    public virtual string GetStringRepresentation()
    {
        return $"{_goalType}:{_goalName}~~{_goalDescription}~~{_goalPoint}";
    }
}