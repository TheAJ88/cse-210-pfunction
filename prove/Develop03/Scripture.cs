using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

class Scripture
{
    private List<string> _scripture;
    private string _option;


    public Scripture()
    {
        _scripture.Add("");
        _scripture.Add("");
        _scripture.Add("");
        _scripture.Add("");
        _scripture.Add("");
    }
    public void SetOption(string option)
    {
        _option = option;
    }
     
    

}