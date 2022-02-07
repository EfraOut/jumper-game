class Director {

    private bool isPlaying = true;
    public Director()
    {
    }

    public void StartGame()
    {
        while (isPlaying) {
             GetInputs();
             DoUpdates();
             DoOutputs();
        }
    }

    private void GetInputs()
    {
        
    }
    private void DoUpdates()
    {

    }
    private void DoOutputs()
    {

    }
}