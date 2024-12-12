using System;

class MainMenu
{
    protected string _option;
    protected string _type;
    public string BaseMenu()
    {
        Console.WriteLine("Menu Options: ");
        Console.WriteLine(@"
        1. Create New Goal
        2. List Goals
        3. Save Goals
        4. Load Goals
        5. Record Event
        6. Quit");
        Console.WriteLine();
        Console.Write("Select a choice from the menu: ");
        _option = Console.ReadLine();
        return _option;
    }
    public string GoalMenu()
    {
        Console.WriteLine("The Goals are: ");
        Console.WriteLine(@"
        1. Simple Goal
        2. Eternal Goals
        3. Checklist Goal");
        Console.WriteLine();
        Console.Write("What type of goal would you like to create? ");
        _option = Console.ReadLine();
        return _option;
    }
    public string TypeSet(string option)
    {
        if(option=="1")
        {
            _type = "SimpleGoal";
        }
        if(option=="2")
        {
            _type = "EternalGoal";
        }
        if(option=="3")
        {
            _type = "ChecklistGoal";
        }
        return _type;
    } 
}