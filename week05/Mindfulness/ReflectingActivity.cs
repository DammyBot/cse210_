using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private Random _rand = new Random();

    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience?",
        "What did you learn about yourself?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectingActivity()
        : base("Reflecting",
               "This activity helps you reflect on times in your life when you were strong, thoughtful, or kind.")
    {}

    public void Run()
    {
        DisplayStartingMessage();
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }

    public string GetRandomQuestion()
    {
        return _questions[_rand.Next(_questions.Count)];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($" --- {GetRandomPrompt()} --- ");
        Console.WriteLine("\nWhen you have an experience in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on the following questions:");
        Console.WriteLine("You may begin in...");
        ShowCountDown(5);
    }

    public void DisplayQuestions()
    {
        int totalTime = GetDuration();
        int elapsed = 0;

        while (elapsed < totalTime)
        {
            Console.Write("\n> " + GetRandomQuestion() + " ");
            ShowSpinner(5);
            elapsed += 5;
        }
    }
}
