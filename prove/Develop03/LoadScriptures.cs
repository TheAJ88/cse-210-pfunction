using System;
using Microsoft.VisualBasic;

class LoadScriptures
{
    private string _reference;
    private string _book;
    private int _chapter;
    private int _startVerse=0;
    private int _endVerse = 0;
    private string _scripture;
    private string _section;
    public void Loader(string section)
    {
        string[] lines = File.ReadAllLines("scripture_database.txt");
        _section = section;
        for(int i = 0; i<lines.Length; i+=2)
        {
            Console.WriteLine(i);
            _reference = lines[i];
            string[] script = _reference.Split("~~");
            if(script[0]==_section)
            {    
                _scripture = lines[i+1];
                string[] refparts = script[1].Split("^");
                _book = refparts[0];
                string[] refverse = refparts[1].Split(":");
                _chapter = int.Parse(refverse[0]);
                if(refverse[1].Length==5||refverse[1].Length==6)
                {
                    string[] verses = refverse[1].Split("-");
                    _startVerse = int.Parse(verses[0]);
                    _endVerse = int.Parse(verses[1]);
                }
                else _startVerse = int.Parse(refverse[1]);
                break;
            }
            else continue;
        }
    }
    public Reference GetReference()
    {
        if(_endVerse==0)
        {
            Reference reference = new Reference(_book, _chapter, _startVerse);
            return reference;
        }
        else{
            Reference reference = new Reference(_book, _chapter, _startVerse, _endVerse);
            return reference;
        }
    }
    public string GetScripture()
    {
        return _scripture;
    }
}