using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        string userNumber = PromptUserNumber();
        string squaredNumber = SquaredNumber(userNumber);
        DisplayResult(userName, squaredNumber);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static String PromptUserNumber()
    {
        Console.Write("Please enter your favourite number: ");
        string number = Console.ReadLine();
        return number;
    }

    static String SquaredNumber(string number)
    {
        int num = int.Parse(number);
        int squared = num * num;
        return squared.ToString();
    }

    static void DisplayResult(string name, string squaredNumber)
    {
        Console.WriteLine($"{name}, the square of your number is {squaredNumber}.");
    }
}