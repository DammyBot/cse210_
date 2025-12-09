using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store activity objects
        List<Activity> activities = new List<Activity>();

        // Create activities with hard-coded values
        Running run = new Running("2025-12-10", 30, 4.8);
        Cycling cycle = new Cycling("2025-12-11", 45, 20.5);
        Swimming swim = new Swimming("2025-12-12", 25, 40);

        // Add them to the list
        activities.Add(run);
        activities.Add(cycle);
        activities.Add(swim);

        // Display summaries
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
