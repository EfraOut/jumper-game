public class TerminalService
{
    public TerminalService()
    {
    }
    /// <summary>
    /// Gets text input from the terminal. Directs the user with the given prompt.
    /// </summary>
    /// <param name="prompt">The given prompt.</param>
    /// <returns>Inputted text.</returns>
    public string ReadText(string prompt)
    {
        Console.Write(prompt);
        return Console.ReadLine();
    }

    /// <summary>
    /// Displays the given text on the terminal. 
    /// </summary>
    /// <param name="text">The given text.</param>
    public void WriteText(string text)
    {
        Console.WriteLine(text);
    }
}
