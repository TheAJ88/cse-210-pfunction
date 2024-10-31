using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
    private string _homeworkList;
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList()
    {
        _homeworkList = ($"Sections {_textbookSection}, Problems {_problems}");
        return _homeworkList;
    }
}