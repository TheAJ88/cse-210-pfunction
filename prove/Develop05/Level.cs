using System;

class Level
{
    protected int _points;
    protected int _level;
    protected int _bonus;
    public int LevelSystem(int points)
    {
        _points = points;
        if(_points>=50)
        {
            _level = 1;
        }
        if(_points>=100)
        {
            _level = 3;
        }
        if(_points>=200)
        {
            _level = 3;
        }
        if(_points>=350)
        {
            _level = 4;
        }
        if(_points>=500)
        {
            _level = 5;
        }
        return _level;
    }
    public int MilestoneBonus(List<Goal> goals)
    {
        int milestoneCount = 0;
        foreach(Goal entry in goals)
        {
            if(entry.GetCompletion()==true)
            {
                milestoneCount++;
            }
        }
        if(milestoneCount==3)
        {
            _bonus = 25;
            Console.WriteLine($"Congratulations on your first milestone! Here's a bonus for ya: {_bonus}. Keep working hard!");
        }
        if(milestoneCount==10)
        {
            _bonus = 50;
            Console.WriteLine($"Congratulations on your second milestone! Here's a bonus for ya: {_bonus}. Never give up on your dreams!");
        }
        if(milestoneCount==15)
        {
            _bonus = 100;
            Console.WriteLine($"Congratulations on your third milestone! Here's a bonus for ya: {_bonus}. Be confident in your ability!");
        }
        if(milestoneCount==22)
        {
            _bonus = 200;
            Console.WriteLine($"Congratulations on your final milestone! Here's a bonus for ya: {_bonus}. Those dearest to you are proud!");
        }
        return _bonus;
    }
}