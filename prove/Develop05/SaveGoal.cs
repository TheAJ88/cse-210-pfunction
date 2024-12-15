using System;

public class SaveGoal 
{
    private string _fileName;
    public void FileModder(List<Goal> goals, int points)
    {
        Console.WriteLine("What is your filename? : ");
        _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            outputFile.WriteLine(points);
            foreach (Goal entry in goals)
            {
                outputFile.WriteLine(entry.GetStringRepresentation());
            }
        }
    }
    
}