using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Mindfulness Program");
            Console.WriteLine("----------------------");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflecting Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("\nSelect an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                int duration = GetDurationFromUser();
                BreathingActivity act = new BreathingActivity();
                act.SetDuration(duration);
                act.Run();
            }
            else if (choice == "2")
            {
                int duration = GetDurationFromUser();
                ReflectingActivity act = new ReflectingActivity();
                act.SetDuration(duration);
                act.Run();
            }
            else if (choice == "3")
            {
                int duration = GetDurationFromUser();
                ListeningActivity act = new ListeningActivity(duration);
                act.SetDuration(duration);
                act.Run();
            }
            else if (choice == "4")
            {
                running = false;
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter and try again.");
                Console.ReadLine();
            }
        }
    }

    static int GetDurationFromUser()
    {
        Console.Write("\nEnter the duration for the activity (seconds): ");
        int seconds = int.Parse(Console.ReadLine());
        return seconds;
    }
}
