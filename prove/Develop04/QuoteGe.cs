using System;

class QuoteGen
{
    protected string _quote;
    protected List<string> _inspirationalQuotes = new List<string>
        {
            "The only way to do great work is to love what you do. - Steve Jobs",
            "Success is not the key to happiness. Happiness is the key to success. - Albert Schweitzer",
            "Believe you can and you're halfway there. - Theodore Roosevelt",
            "Don’t watch the clock; do what it does. Keep going. - Sam Levenson",
            "The future belongs to those who believe in the beauty of their dreams. - Eleanor Roosevelt",
            "You miss 100% of the shots you don’t take. - Wayne Gretzky",
            "It does not matter how slowly you go as long as you do not stop. - Confucius",
            "Act as if what you do makes a difference. It does. - William James",
            "Dream big and dare to fail. - Norman Vaughan",
            "The best time to plant a tree was 20 years ago. The second best time is now. - Chinese Proverb",
            "Success is how high you bounce when you hit bottom. - George S. Patton",
            "Your time is limited, so don’t waste it living someone else’s life. - Steve Jobs",
            "Hardships often prepare ordinary people for an extraordinary destiny. - C.S. Lewis",
            "Everything you’ve ever wanted is on the other side of fear. - George Addair",
            "Start where you are. Use what you have. Do what you can. - Arthur Ashe"
        };
    public void QuoteSend()
    {
        Random random = new Random();
        _quote = _inspirationalQuotes[random.Next(_inspirationalQuotes.Count)];
        Console.WriteLine(_quote);
    }
}