public class Puzzle
{
    private string[] wordList = {"mosaic", "bounce", "wear", "freshman", "writer", "scatter", 
    "provide", "withdrawal", "launch", "pull"};

    private List<string> wrongGuess = new List<string>(); 
    private List<string> correctGuess = new List<string>(); 
    private List<string> deconstructedWord = new List<string>();    
    public int guessNum = 4;
    public string word = "";
    TerminalService ts = new TerminalService();

    public Puzzle()
    {
        Random random = new Random();
        word = wordList[random.Next(0, wordList.Length - 1)];
        for (int i = 0; i < word.Length; i++)
        {
            deconstructedWord.Add(word[i].ToString());
        }
    }

    public void printWord()
    {
        for (int i = 0; i < word.Length; i++)
        {
            Console.Write("_ ");
        }
    }
    // Compares the user's input with the actual word
   public void compareGuess(string guess)
    {
        if (deconstructedWord.Contains(guess))
        {
            correctGuess.Add(guess);
        }
        else
        {
            wrongGuess.Add(guess);
            guessNum -= 1;
        }
    }

    // Tells if the correct guesses are equal to the actual word


}