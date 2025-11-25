using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Dammy", "Game Development");
        // Console.WriteLine(assignment.GetSummary());

        MathAssignment mathAssignment = new MathAssignment("7.3", "1-10", "Dammy", "Fractions");
        // Console.WriteLine(mathAssignment.GetSummary());
        // Console.WriteLine(mathAssignment.GetHomeworkList());

        WritingAssignment writingAssignment = new WritingAssignment("The Causes of World War II", "Dammy", "History");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}