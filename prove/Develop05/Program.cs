using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using Microsoft.VisualBasic;
class Program
{
    static void Main(string[] args)
    {
        string _mainOption = "0";
        var goals = new List<Goal>();
        string welcomeMessage = "WELCOME TO ETERNALQUEST!";
        string art = @"(\ 
\'\ 
 \'\     __________  
 / '|   ()_________)
 \ '/    \ ~~~~~~~~ \
   \       \ ~~~~~~   \
   ==).      \__________\
  (__)       ()__________)";
        Console.WriteLine(welcomeMessage);
        Console.WriteLine(art);
        Thread.Sleep(1500);
        int _totalPoints = 0;
        while(_mainOption!="6")
        {
            Level level = new Level();
            int milestoneBonus = level.MilestoneBonus(goals);
            _totalPoints = _totalPoints + milestoneBonus;
            string _goalOption;
            Console.WriteLine();
            Console.WriteLine($"You have {_totalPoints} points.\n");
            int _level = level.LevelSystem(_totalPoints);
            Console.WriteLine($"Your level is {_level}");
            MainMenu menu = new MainMenu();
            _mainOption = menu.BaseMenu();
            if(_mainOption=="1")
            {
                _goalOption = menu.GoalMenu();
                if(_goalOption=="1")
                {
                    string goalType = menu.TypeSet(_goalOption);
                    SimpleGoal simplegoal = new SimpleGoal();
                    simplegoal.GoalEntrySpecific();
                    simplegoal.SetType(goalType);
                    goals.Add(simplegoal);
                } 
                if(_goalOption=="2")
                {
                    string goalType = menu.TypeSet(_goalOption);
                    EternalGoal eternalgoal = new EternalGoal();
                    eternalgoal.GoalEntrySpecific();
                    eternalgoal.SetType(goalType);
                    goals.Add(eternalgoal);
                }
                if(_goalOption=="3")
                {
                    string goalType = menu.TypeSet(_goalOption);
                    ChecklistGoal checklistgoal = new ChecklistGoal();
                    checklistgoal.GoalEntrySpecific();
                    checklistgoal.SetType(goalType);
                    goals.Add(checklistgoal);
                }
            }
            if(_mainOption=="2")
            {
                LoadingAnimation ln = new LoadingAnimation(2);
                Console.WriteLine();
                DisplayGoal display = new DisplayGoal(goals);
                display.ListDisplay();
            } 
            if(_mainOption=="3")
            {
                SaveGoal save = new SaveGoal();
                save.FileModder(goals, _totalPoints);
            }
            if(_mainOption=="4")
            {
                LoadGoal load = new LoadGoal();
                load.FileModder();
                goals.Clear();
                goals = load.GetList();
                _totalPoints = load.GetPoints();
            }
            if(_mainOption=="5")
            {
                GoalCompletion complete = new GoalCompletion(goals);
                complete.Update();
                _totalPoints = _totalPoints + complete.UpdatePoints();
            }
        }
    }
}