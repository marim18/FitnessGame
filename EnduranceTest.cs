class EnduranceTest
{
    public void Start()
    {
        Console.WriteLine("Endurance test started.");
        Console.WriteLine("Press any key to stop the test.");
        Console.ReadKey();
        Console.WriteLine("Endurance test stopped.");
    }
    public void ShowResult(int time)
    {
        Console.WriteLine($"You lasted {time} seconds.");
    }
}
