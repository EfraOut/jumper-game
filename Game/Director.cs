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
        while (isPlaying) 
        {
             GetInputs();
            //  DoUpdates();
             DoOutputs();
        }
    }

    private void GetInputs()
    {
        terminalService.WriteText(puzzle.word);
        jumper.drawChute(puzzle.guessNum);
        puzzle.printWord();
        guess = terminalService.ReadText("\nEnter a letter [a-z]: ");
        puzzle.compareGuess(guess);

    }
    private void DoUpdates()
    {

    }
    private void DoOutputs()
    {
    }
}