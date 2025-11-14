public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] parts = text.Split(" ");

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = rand.Next(_words.Count);

            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }

            // If all words are hidden, stop.
            if (IsCompletelyHidden()) break;
        }
    }

    
    public string GetDisplayTest()
    {
        List<string> displayWords = new List<string>();

        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayTest());
        }

        string scriptureText = string.Join(" ", displayWords);

        return $"{_reference.GetDisplayText()} - {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }


}