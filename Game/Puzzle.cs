public class Puzzle
{
    private string[] wordList = {"mosaic", "bounce", "wear", "freshman", "writer", "scatter", 
    "provide", "withdrawal", "launch", "pull"};
    private List<string> wrongGuess = new List<string>();
    private List<string> correctGuess = new List<string>();
    private List<string> wordOutput = new List<string>();
    public int guessNum = 4;
    public string word = "";
    // Constructor for the Puzzle
    public Puzzle()
    {
        Random random = new Random();
        word = wordList[random.Next(0, wordList.Length - 1)];
        for (int i = 0; i < word.Length; i++)
        {
            wordOutput.Add("_ ");
        }
    }
    // Displays the word according to the current guesses
    public void printWord()
    {
        foreach (string letter in wordOutput)
        {
            Console.Write(letter);
        }
    }
    // Compares the user's input with the actual word
   public void compareGuess(string guess)
    {
        if (word.Contains(guess))
        {
            correctGuess.Add(guess);
        }
        else
        {
            wrongGuess.Add(guess);
            guessNum -= 1;
        }
    }
    // Changes the output for the correct guesses
    public void changeWord(string guess)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].ToString() == guess)
            {
            wordOutput[i] = guess;
            }
        }
    }
    // Tells if the word is already completed
    public bool checkGameOver()
    {
        if (!wordOutput.Contains("_ "))
        {
            return false;
        }
        else
        {
            return true;   
        }
    }
}