public class Puzzle
{
    private string[] wordList = {"mosaic", "bounce", "wear", "freshman", "writer", "scatter", 
    "provide", "withdrawal", "launch", "pull"};

    private string[] wrongGuesses;
    private string[] correctGuesses; 
    public int guessNum = 4;
    public string word = "";
    TerminalService ts = new TerminalService();

    public Puzzle()
    {
        Random random = new Random();
        word = wordList[random.Next(0, wordList.Length - 1)];
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
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i].ToString() == guess)
            {
                
            ts.WriteText("It is present");
            
            }
        }
    }

    // Tells if the correct guesses are equal to the actual word


}