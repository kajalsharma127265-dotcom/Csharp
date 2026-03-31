using System;

// Interface Exam
interface Exam
{
    bool Pass(int mark);
}

// Interface Classify
interface Classify
{
    string Division(int average);
}

// Class Result implementing both interfaces
class Result : Exam, Classify
{
    // Implement Pass method
    public bool Pass(int mark)
    {
        if (mark >= 50)
            return true;
        else
            return false;
    }

    // Implement Division method
    public string Division(int average)
    {
        if (average >= 60)
            return "First";
        else if (average >= 50)
            return "Second";
        else
            return "No division";
    }
}

// Main class
class Program
{
    static void Main()
    {
        Result r = new Result();

        Console.Write("Enter marks: ");
        int marks = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter average: ");
        int avg = Convert.ToInt32(Console.ReadLine());

        // Check pass or fail
        Console.WriteLine("Pass Status: " + r.Pass(marks));

        // Display division
        Console.WriteLine("Division: " + r.Division(avg));
    }
}
