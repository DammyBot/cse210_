class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("=== SCRIPTURE MEMORIZER ===\n");

        // 1. USER SELECTS DIFFICULTY
        int difficulty = SelectDifficulty();

        // 2. RANDOM SCRIPTURE SELECTION
        Scripture scripture = GenerateRandomScripture();

        Console.Clear();
        Console.WriteLine("=== SCRIPTURE MEMORIZER ===\n");
        Console.WriteLine(scripture.GetDisplayTest());
        Console.WriteLine("\nPress Enter to hide words, or type 'quit' to exit.");

        // 3. SCRIPTURE HIDING LOOP
        while (true)
        {
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords(difficulty);
            Console.Clear();

            Console.WriteLine("=== SCRIPTURE MEMORIZER ===\n");
            Console.WriteLine(scripture.GetDisplayTest());

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("\n🎉 All words are hidden! Great job staying focused!");
                break;
            }

            Console.WriteLine("\nPress Enter to hide more words, or type 'quit' to exit.");
        }
    }

    // DIFFICULTY SYSTEM

    static int SelectDifficulty()
    {
        Console.WriteLine("Choose Difficulty:");
        Console.WriteLine("1. Easy   (1 word at a time)");
        Console.WriteLine("2. Medium (3 words at a time)");
        Console.WriteLine("3. Hard   (5 words at a time)");
        Console.Write("\nEnter 1, 2, or 3: ");

        while (true)
        {
            string choice = Console.ReadLine();

            if (choice == "1") return 1;
            if (choice == "2") return 3;
            if (choice == "3") return 5;

            Console.Write("Invalid choice. Enter 1, 2, or 3: ");
        }
    }

    // RANDOM SCRIPTURE SELECTION

    static Scripture GenerateRandomScripture()
    {
        var scriptures = new List<(Reference, string)>
        {
            (
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),
            (
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            ),
            (
                new Reference("Psalm", 23, 1),
                "The Lord is my shepherd I shall not want"
            ),
            (
                new Reference("Romans", 8, 28),
                "All things work together for good to them that love God"
            )
        };

        Random rand = new Random();
        int index = rand.Next(scriptures.Count);

        var (reference, text) = scriptures[index];

        return new Scripture(reference, text);
    }
}
