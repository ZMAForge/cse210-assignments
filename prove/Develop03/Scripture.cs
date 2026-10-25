using System.ComponentModel.DataAnnotations;

class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture (string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = CreateVerseReference(bookName, chapter, verse);
    }
    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = CreateVersesReference(bookName, chapter, startVerse, endVerse);
    }

    public void ShowScripture()
    {
        Console.Clear();
        _reference.ShowReference();
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    /***************************************************
    *ConvertToWordList() -this methiod will recieve a string paramater,
    * whuch is a paragraph of text. It will split that text into words and
    * add those words to a list<word> and return that list
    ******************************************************/
    private List<Word> ConvertToWordList(string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[ ] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }

        return tempWordList;
    }
    private Reference CreateVerseReference(string name, int chapter, int verse)
    {
        Reference myReference = new Reference(name, chapter, verse);
        return myReference;
    }
    
    private Reference CreateVersesReference(string name, int chapter, int stVerse, int enVerse)
    {
        Reference myReference = new Reference(name, chapter, stVerse, enVerse);
        return myReference;
    }

    public bool HideSomeWords()
    {
        int visibleWords = _words.Count(w => !w.IsHidden());
        int countKey = NumberOfHiddenWords();
        int counter = 0;
        Random ran = new Random();

        countKey = Math.Min(countKey, visibleWords);
        while (counter < countKey)
        {
            int hideIndex = ran.Next(0, _words.Count);
            if(!_words[hideIndex].IsHidden())
            {
                _words[hideIndex].Hide();
                counter = counter + 1;
            }
        }

        foreach (Word word in _words)
        {
            if(!word.IsHidden())
            return true;
        }

        return false;
    }

    private int NumberOfHiddenWords()
    {
        Random rnd = new Random();
        int hiddenNum = rnd.Next(1,5);
        return hiddenNum;
    }
    // I think I get it? Hide some words will call number of hidden words which will return a number
    //Hide some words will then run a loop that many times hidding words in random spots using word[num].Hide()
}