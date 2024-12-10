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
        Console.WriteLine("Hello Develop05 World!");
        int screenWidth = Console.WindowWidth;
        int stringWidth = welcomeMessage.Length;
        int spaces = (screenWidth / 2) + (stringWidth / 2);
        Console.WriteLine(welcomeMessage.PadLeft(spaces));
        Console.WriteLine(art);
        int _totalPoints = 0;
        while(_mainOption!="6")
        {
            string _goalOption;
            Console.WriteLine($"You have {_totalPoints} points.\n");
            if(_totalPoints==100)
            {
                Console.WriteLine("THE GREAT HUNDRED! CONGRATULATIONS AGAIN! Here's 25 bonus points! Go treat yourself by taking a well-deserved break!");
                _totalPoints = _totalPoints+25;
            }
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
                DisplayGoal display = new DisplayGoal(goals);
                display.ListDisplay();
            } 
            if(_mainOption=="3")
            {
                SaveGoal save = new SaveGoal();
                save.FileModder(goals);
            }
            if(_mainOption=="4")
            {
                LoadGoal load = new LoadGoal();
                load.FileModder();
                goals.Clear();
                goals = load.GetList();
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