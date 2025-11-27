using System;
using System.Collections.Generic;

public class ListeningActivity : Activity
{
    private int _count;
    private Random _rand = new Random();

    private List<string> _prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt spiritual peace recently?",
        "Who are some of your personal heroes?"
    };

    public ListeningActivity(int count)
        : base("Listing",
               "This activity helps you focus on the good things in your life.")
    {
        _count = count;
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("\nList as many responses as you can.");
        Console.WriteLine($"Prompt: {GetRandomPrompt()}\n");

        List<string> items = GetListFromUser();

        Console.WriteLine($"\nYou listed {items.Count} items!");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    public List<string> GetListFromUser()
    {
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            items.Add(Console.ReadLine());
        }

        return items;
    }
}
