using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() 
        : base("Breathing",
               "This activity will help you relax by walking you through slow breathing in and out.")
    {}

    public void Run()
    {
        DisplayStartingMessage();

        int totalTime = GetDuration();
        int elapsed = 0;

        while (elapsed < totalTime)
        {
            Console.Write("\nBreathe in... ");
            ShowCountDown(4);
            elapsed += 4;
            if (elapsed >= totalTime) break;

            Console.Write("Now breathe out... ");
            ShowCountDown(6);
            elapsed += 6;
        }

        DisplayEndingMessage();
    }
}
