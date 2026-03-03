using System;

class Program
{
    static void Main()
    {
        int[] marks = new int[5];
        int total = 0;
        double average;

        Console.WriteLine("Enter marks of 5 students:");

        // Store marks in array
        for (int i = 0; i < marks.Length; i++)
        {
            marks[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Calculate total marks
        for (int i = 0; i < marks.Length; i++)
        {
            total += marks[i];
        }

        // Calculate average
        average = (double)total / marks.Length;

        Console.WriteLine("Total Marks = " + total);
        Console.WriteLine("Average Marks = " + average);
    }
}
