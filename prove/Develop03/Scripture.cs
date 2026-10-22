class Scripture
{
    private List<Word> _words;
    //TODO = Add Scripture Reference

    public Scripture (string bookName, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _words[7].Hide();
    }
    public Scripture (string bookName, int chapter, int startVerse, int endVerse, string text)
    {
        //TODO
    }

    public void ShowScripture()
    {
        foreach(Word word in _words)
        {
            word.Display();
        }
    }

    //TODO add constructor for ScriptureReference

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
}