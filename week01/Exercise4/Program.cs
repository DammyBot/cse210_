using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        int sum = 0;
        float average;
        int largest;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        // number = int.Parse(Console.ReadLine());
        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0) { numbers.Add(number); }
        }

        foreach (int num in numbers) { sum += num; }
        average = sum / numbers.Count;
        largest = numbers.Max();

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}