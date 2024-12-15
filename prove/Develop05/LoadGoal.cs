using System;

class LoadGoal
{
    private string _fileName;
    protected int _points;
    protected List<Goal> SetList;
    public  void FileModder()
    {
        List<Goal> _goals = new List<Goal>();
        Console.WriteLine("Enter filename : ");
        _fileName = Console.ReadLine();

        string[] lines = File.ReadAllLines(_fileName);
        _points = int.Parse(lines[0]);

        for(int i = 1; i< lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split(":");
            string goalType = parts[0];
            string goal = parts[1];
            string[] goalDetails = goal.Split("~~");
            if(goalType=="SimpleGoal")
            {
                string name = goalDetails[0];
                string description = goalDetails[1];
                int points = int.Parse(goalDetails[2]);
                Boolean completion = bool.Parse(goalDetails[3]);
                SimpleGoal simple = new SimpleGoal();
                simple.SetType(goalType);
                simple.SetLoadValues(name, description, points, completion);
                _goals.Add(simple);
            }
            if(goalType=="EternalGoal")
            {
                string name = goalDetails[0];
                string description = goalDetails[1];
                int points = int.Parse(goalDetails[2]);
                EternalGoal eternal = new EternalGoal();
                eternal.SetLoadValues(name, description, points);
                _goals.Add(eternal);
            }
            if(goalType=="ChecklistGoal")
            {
                string name = goalDetails[0];
                string description = goalDetails[1];
                int points = int.Parse(goalDetails[2]);
                int bonus = int.Parse(goalDetails[3]);
                int bonusTimes = int.Parse(goalDetails[4]);
                int realTimes = int.Parse(goalDetails[5]);
                ChecklistGoal checklist = new ChecklistGoal();
                checklist.SetLoadValues(name, description, points, bonus, bonusTimes, realTimes);
                _goals.Add(checklist);
            }
        }
        SetList = _goals;
    }

    public List<Goal> GetList()
    {
        return SetList;
    }
    public int GetPoints()
    {
        return _points;
    }
}