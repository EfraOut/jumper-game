class Puzzle
{
    private string[] wordList = {"mosaic", "bounce", "wear", "freshman", "writer", "scatter", 
    "provide", "withdrawal", "launch", "pull"};

    private int guess = 3;

    public string getWord()
    {
        Random random = new Random();
        string word = wordList[random.Next(0, wordList.Length - 1)];
        return word;
    }
}