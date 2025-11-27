using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration = 0)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity!\n");
        Console.WriteLine(_description);
        Console.WriteLine($"\nThis activity will last for {_duration} seconds.");
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.\n");
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write("\r" + spinner[index]);
            Thread.Sleep(250);
            index = (index + 1) % spinner.Length;
        }

        Console.Write("\r ");
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + " ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
