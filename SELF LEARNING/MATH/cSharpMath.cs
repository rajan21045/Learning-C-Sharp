// The C# Math class has many methods that allows you to perform mathematical tasks on numbers.
using System;
class Program
{
    static void Main()
    {
        int num1 = 10;
        int num2 = 20;
        // 1. Write a program that demonstrates the use of at least five different methods from the Math class (e.g., Math.Abs, Math.Sqrt, Math.Pow, Math.Max, Math.Min).
        Console.WriteLine("Maximum of {0} and {1} is: {2}", num1, num2, Math.Max(num1, num2));
        Console.WriteLine("Minimum of {0} and {1} is: {2}", num1, num2, Math.Min(num1, num2));
        Console.WriteLine("Absolute value of -5 is: {0}", Math.Abs(-5));
        Console.WriteLine("Square root of 16 is: {0}", Math.Sqrt(16));
        Console.WriteLine("2 raised to the power of 3 is: {0}", Math.Pow(2, 3));
        Console.WriteLine("Ceiling of 5.6 is: {0}", Math.Ceiling(5.6));
        Console.WriteLine("Floor of 5.6 is: {0}", Math.Floor(5.6));
        Console.WriteLine("Round of 5.4 is: {0}", Math.Round(5.4));

    }
}