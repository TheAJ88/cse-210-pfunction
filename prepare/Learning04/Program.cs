using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");
        Assignment sum = new Assignment("Akshat Johanan", "Inheritance");
        Console.WriteLine(sum.GetSummary());

        MathAssignment mathhw = new MathAssignment("Akshat Johanan", "Systems of Equations", "4-1", "1-17");
        Console.WriteLine(mathhw.GetSummary());
        Console.WriteLine(mathhw.GetHomeworkList());

        WritingAssignment enghw = new WritingAssignment("Akshat Johanan", "Themes in Literature", "Do Androids dream of Electric Sheep?");
        Console.WriteLine(enghw.GetSummary());
        Console.WriteLine(enghw.GetWritingInformation());
    }
}