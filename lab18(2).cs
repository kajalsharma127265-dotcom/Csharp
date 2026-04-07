using System;

class TryCatchFinallyDemo
{
    static void Main()
    {
        int a, b, result;

        try
        {
            Console.Write("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            b = Convert.ToInt32(Console.ReadLine());

            result = a / b;   // This may cause an exception if b = 0

            Console.WriteLine("Result = " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        finally
        {
            Console.WriteLine("Program execution completed.");
        }

        Console.ReadKey();
    }
}