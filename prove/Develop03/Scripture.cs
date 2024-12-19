class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private int _stringLength;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        string[] words = text.Split(" "); 
        _stringLength = words.Length;
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }
    }

public void HideRandomWords(int count)
{
    Random random = new Random();
    int hiddenCount = 0; 

    while (hiddenCount < count)
    {
        int index = random.Next(_words.Count); 
        if (!_words[index].IsHidden()) 
        {
            _words[index].Hide(); 
            hiddenCount++; 
        }
    }
}
    public string Display()
    {
        string scriptureText = _reference.Display() + "\n";

        foreach (Word word in _words)
        {
            scriptureText += word.Display() + " "; 
        }

        return scriptureText.Trim(); 
    }

    public bool AllWordsHidden()
    {
        int i = 0;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                i++;
            }
        }
        if (i==_stringLength)
        {
            return true;
        }
        else return false;
    }
    
}