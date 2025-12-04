using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Title = "Eternal Quest Program";

        ShowTitle();

        GoalManager manager = new GoalManager();
        manager.Start();

        Console.ResetColor();
        Console.WriteLine("\nThanks for using Eternal Quest! Goodbye.\n");
    }

    static void ShowTitle()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("========================================");
        Console.WriteLine("          WELCOME TO ETERNAL QUEST       ");
        Console.WriteLine("========================================");
        Console.ResetColor();

        Console.WriteLine("Track goals, earn points, and improve yourself!");
        Console.WriteLine("Press ENTER to continue...");
        Console.ReadLine();
        Console.Clear();
    }
}
