using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;


public class Journal2
{
    public string _fileName;
    public List<Entry2> entries= new List<Entry2>();

    public void EntryManager()
    {
        Entry2 e2 = new Entry2(); 
        e2.journalEntry();
        entries.Add(e2); 
    }

    public void Display()
    {
        foreach(Entry2 e in entries)
        {
            e.Display();
        }
    }

    public void Savefile(string fileName)
    {
        // if (File.Exists(fileName))
        // {
        //     using (StreamWriter sw = File.AppendText(fileName))
        //     {
        //         foreach (Entry2 entry in entries)
        //         sw.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entryText}");
        //     }
        // }
        // else
        {
            using (StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach (Entry2 entry in entries)
                {
                    outputFile.WriteLine($"{entry._date}~~{entry._prompt}~~{entry._entryText}");
                }
            }
        }
            
    }

    public void Loadfile(string f)
    {
        entries.Clear();
        string[] lines = File.ReadAllLines(f);
        foreach(string line in lines)
        {
            string[] parts = line.Split("~~");
            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
            
            Entry2 e = new Entry2();
            e._date = date;
            e._prompt = prompt;
            e._entryText = entry;
            entries.Add(e);
        }
    }
}