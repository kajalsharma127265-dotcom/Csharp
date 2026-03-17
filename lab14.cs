using System;

class Student
{
    int rollNo;
    string name;
    int marks;
    string grade;

    public Student()
    {
        rollNo = 0;
        name = "Unknown";
        marks = 0;
    }
    public Student(int r, string n, int m)
    {
        rollNo = r;
        name = n;
        marks = m;
    }
    public void CalculateGrade()
    {
        if (marks >= 80)
            grade = "A";
        else if (marks >= 60)
            grade = "B";
        else if (marks >= 40)
            grade = "C";
        else
            grade = "F";
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Roll No: " + rollNo);
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Marks: " + marks);
        Console.WriteLine("Grade: " + grade);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(101, "Amit", 75);

        s1.CalculateGrade();
        s1.DisplayDetails();
    }
}
