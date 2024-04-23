class LungeTest
{
    public void Show()
    {
        Console.WriteLine("Welcome to the Lunge Test!");
        Console.WriteLine("Instructions:");
        Console.WriteLine("1. Stand up straight.");
        //(...)
        Console.WriteLine("Press any key to start the test...");
        Console.ReadKey();
    }

    public void ShowResult(int count)
    {
        Console.WriteLine("Test completed!");
        Console.WriteLine("Number of lunges: " + count);
    }
}
