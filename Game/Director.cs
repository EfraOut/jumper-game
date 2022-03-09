public class Director {

    public Puzzle puzzle = new Puzzle();
    Jumper jumper = new Jumper();
    TerminalService terminalService = new TerminalService();
    private string guess = "";
    private bool isPlaying = true;
    public Director()
    {
    }
    public void StartGame()
    {
        while (isPlaying && puzzle.guessNum != 0)
        {
             displayGame();
             GetInputs();
             DoUpdates();
        }
        jumper.drawChute(puzzle.guessNum);
        terminalService.WriteText("The word is: " + puzzle.GetWord());
        terminalService.WriteText("Thank you for playing!");
    }
    private void displayGame()
    {
        jumper.drawChute(puzzle.guessNum);
        puzzle.printWord();
    }
    private void GetInputs()
    {
        guess = terminalService.ReadText("\nEnter a letter [a-z]: ");
    }
    private void DoUpdates()
    {
        puzzle.compareGuess(guess);
        puzzle.changeWord(guess);
        isPlaying = puzzle.checkGameOver();
    }
}