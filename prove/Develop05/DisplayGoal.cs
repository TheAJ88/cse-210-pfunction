using System;
using Microsoft.VisualBasic;

class DisplayGoal
{
    protected List<Goal> _new_goals;

    public DisplayGoal(List<Goal> goals)
    {
        _new_goals = goals;
    }
    public void ListDisplay()
    {
        Console.WriteLine("The goals are:");
        int n = 1;
        foreach(Goal entry in _new_goals)
        {
            string _bracks = "{ }";
            if(entry.GetCompletion()==true)
                {
                    _bracks = "{X}";
                }
            Console.WriteLine($"{n}. {_bracks} {entry.DisplayGoal()}");
            n++;
        }
    }
}