using System;  // Provides basic system functionalities like Console and parsing methods

class Program   // Main class of the application
{
    static void Main()   // Entry point of the program
    {
        // Ask user to enter first number
        Console.Write("Enter First Number: ");
        
        // Read input as string
        string num1 = Console.ReadLine();
        
        // Convert string input into integer
        int nums = int.Parse(num1);

        // Ask user to enter second number
        Console.Write("Enter Second Number: ");
        
        // Read and directly convert input into integer
        int nums2 = int.Parse(Console.ReadLine());

        // Calculate the sum of two numbers
        int sum = nums + nums2;

        // Display result using formatted output
        Console.WriteLine("The Sum of {0} & {1} is {2}", nums, nums2, sum);
    }
}