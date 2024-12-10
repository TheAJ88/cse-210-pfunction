using System;
using System.Security.Cryptography.X509Certificates;

class GoalCompletion
{
    protected int _reward;
    protected List<Goal> _newGoals;
    public GoalCompletion(List<Goal>goals)
    {
        _newGoals = goals;
    }
    public void Update()
    {
        int n = 1;
        Console.WriteLine("The goals are:");
        foreach(Goal entry in _newGoals)
        {
            string[] parts = entry.GetStringRepresentation().Split(":");
            string goal = parts[1];
            string[] goalDetails = goal.Split("~~");
            string details = goalDetails[0];
            string display = n + ". " + details;
            Console.WriteLine(display);
            n++;
        }
        Console.WriteLine("What goal did you accomplish? ");
        int goalNumber = int.Parse(Console.ReadLine());
        if(goalNumber<=_newGoals.Count)
        {
                Goal entry = _newGoals[goalNumber-1];
                if(entry.GetCompletion()==false)
                {
                    _reward = entry.GetPoints();
                    Console.WriteLine($"Congratulations! You have earned {_reward} points!");
                    entry.SetPoints(_reward);
                    _reward = entry.GetPoints();
                    if(entry.GetGoal()=="ChecklistGoal")
                    {
                        entry.StatusUpdate();
                        entry.Complete();
                    }
                    if(entry.GetGoal()=="SimpleGoal")
                    {
                        entry.Complete();
                    }
                }
                else
                {
                    Console.WriteLine("This goal is complete!");
                }
        }
        else Console.WriteLine("WRONG INPUT");
    }
    public int UpdatePoints()
    {
        return _reward;
    }
}