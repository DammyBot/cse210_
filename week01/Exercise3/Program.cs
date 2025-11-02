using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int randomNumber = randomGenerator.Next(1, 21);
        Console.WriteLine(randomNumber);
        int guess;
        Console.Write("Guess the magic number: ");
        guess = int.Parse(Console.ReadLine());
        while (randomNumber != guess)
        {
            if (guess < randomNumber) { Console.WriteLine("Higher"); }
            else if (guess > randomNumber) { Console.WriteLine("Lower"); }
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());
        }
        if(randomNumber == guess) { Console.WriteLine("You guessed it!"); }
    }
}