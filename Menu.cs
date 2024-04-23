class Menu
{
    private ReactionTest reactionTest = new ReactionTest();

    public void Show()
    {
        Console.WriteLine("Welcome to the Fitness Game!");
        Console.WriteLine("Choose mode you want to play:");
        Console.WriteLine("1. Reaction test.");
        Console.WriteLine("2. Lunge test.");
        Console.WriteLine("3. Endurance test.");
        Console.WriteLine("4. Mode explanations.");
        Console.WriteLine("5. Exit.");

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                reactionTest.Show();
                reactionTest.StartTest();
                Console.WriteLine("Press any key to stop the test.");
                Console.ReadKey(true);
                reactionTest.StopTest();
                break;
            case 4:
                ShowExplanation();
                break;
            case 5:
                ShowExit();
                break;
            default:
                Console.WriteLine("Invalid choice. Please choose a valid option.");
                break;
        }
    }

    public void ShowExplanation()
    {
        Console.WriteLine("Modes explanation:");
        Console.WriteLine("1. Reaction test: the buttons will light up and you must press them as quickly as possible. This will help you improve your reaction time and your coordination.");
        Console.WriteLine("2. Lunge test: The focus of this wall will be reaction tests with lunges both downwards and upwards.It will be possible to use this as a warmup and part of your regular workout routine.");
        Console.WriteLine("3. Endurance test: You can put the buttons in 4 different locations and stand in between them and then run to the one that lights up, press the button and run back to the center waiting for the next one.");
        Console.WriteLine("Press any key to return to the menu.");
        Console.ReadKey(true);
        Show();
    }

    public void ShowExit()
    {
        Console.WriteLine("Thank you for playing the Fitness Game!");
    }
}
