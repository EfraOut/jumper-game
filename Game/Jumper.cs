public class Jumper
{
    TerminalService ts = new TerminalService();
    // Draws the chute depending on the guesses
    public void drawChute(int guess) 
    {
        if (guess == 4)
        {
            ts.WriteText(@"   ___  ");
            ts.WriteText(@"  /___\ ");
            ts.WriteText(@"  \   / ");
            ts.WriteText(@"   \ /  ");
            ts.WriteText(@"    X   ");
            ts.WriteText(@"^^^^^^^^");
        }
        else if (guess == 3)
        {
            ts.WriteText(@"  /___\ ");
            ts.WriteText(@"  \   / ");
            ts.WriteText(@"   \ /  ");
            ts.WriteText(@"    X   ");
            ts.WriteText(@"^^^^^^^^");

        }
        else if (guess == 2)
        {

            ts.WriteText(@"  \   / ");
            ts.WriteText(@"   \ /  ");
            ts.WriteText(@"    X   ");
            ts.WriteText(@"^^^^^^^^");
        }
        else if (guess == 1)
        {
            ts.WriteText(@"   \ /  ");
            ts.WriteText(@"    X   ");
            ts.WriteText(@"^^^^^^^^");

        }
        else
        {
            ts.WriteText(@"    X   ");
            ts.WriteText(@"^^^^^^^^");
        }
    }
}