using System;

class Program
{
    static void Main(string[] args)
    {
        Reference _reference = new Reference("John 3:16");
        Scripture _scripture = new Scripture(_reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
        
        while (!_scripture.AreWordsHidden())
        {
            _scripture.DisplayScripture();
            Console.WriteLine("Press Enter to continue or type 'quit' to exit:");
            string user = Console.ReadLine();

            if (user.ToLower() == "quit")
            {
                break;
            }
            _scripture.HideRandomWord();
            Console.Clear();   
        }
    }
}

class Scripture
{
    private Reference _reference;
    private string _text;
    private ScriptureWord[] _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        InitializeWords();
    }

    private void InitializeWords()
    {
        string[] wordArray = _text.Split(' ');
        _words = new ScriptureWord[wordArray.Length];
        for (int i = 0; i < wordArray.Length; i++)
        {
            _words[i] = new ScriptureWord(wordArray[i]);
        }
    }

    public void HideRandomWord()
    {
        Random random = new Random();
        int index = random.Next(_words.Length);
        _words[index].Hide();
    }

    public bool AreWordsHidden()
    {
        foreach (ScriptureWord word in _words)
        {
            if (!word.IsHidden)
            {
                return false;
            }
        }
        return true;
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference.GetReferenceText());
        foreach (ScriptureWord word in _words)
        {
            Console.Write(word.GetDisplayText() + " ");
        }
        Console.WriteLine();
    }
}

class Reference
{
    private string _referenceText;

    public Reference(string referenceText)
    {
        _referenceText = referenceText;
    }

    public string GetReferenceText()
    {
        return _referenceText;
    }
}

class ScriptureWord
{
    private string _text;
    private bool _isHidden;

    public ScriptureWord(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return "______";
        }
        else
        {
            return _text;
        }
    }
}
