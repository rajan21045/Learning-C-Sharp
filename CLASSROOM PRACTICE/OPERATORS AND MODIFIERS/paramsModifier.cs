/*
Params is an important keyword in C#. It is used as a parameter which can take the variable number of arguments of specific data type. It is a useful feature when the number of arguments is unknown, providing flexibility in method calls. Some key points involved with params in C# are mentioned below:

    1. It is useful when programmers don’t know the number of parameters to be used.
    2. Only one Params keyword is allowed and no additional Params will be allowed in function declaration after a params keyword.
    3. The length of the params will be zero if no arguments are passed.


Rules
    1. Single params per method: We can only use one params parameter in a method to avoid ambiguity. We need to specify the array type, and all arguments passed must be compatible with that type.
    2. Params must be the last parameter: The params keyword should be the last parameter in the method signature to ensure that the method correctly interprets the arguments.
    3. Empty array: If no arguments are passed to a params parameter, it will be treated as an empty array.


*/

using System;
class Program
{
    static void Main()
    {
        int total = Sum(1, 2, 3, 4, 5); // Call Sum With An Argument Of 1, 2, 3, 4 And 5
        Console.WriteLine("The Total Is: " + total); // Write the value of total to the screen
    }
    static int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int number in numbers)
        {
            total += number; // Add each number to total
        }
        return total; // Return the value of total
    }
}

/*

Benefits of Using Params

    1. Simplifies Method Overloading: Without params, we need to create multiple method overloads to handle different numbers of arguments. This increases the complexity and reduces maintainability. Allows the single method to accept any number of arguments.
    2. Improved Code Readability: It enhances code readability by eliminating the need to manually create arrays or use multiple overloads. Pass values directly to the method in a comma-separated list, making method calls more easier to read.
    3. Flexibility with Argument Count: Allow to pass any number of arguments (including none), making the method more flexible. The method can handle any number of values, making it more versatile and adaptable.
    4. Supports Implicit Array: It automatically wraps values in an array. This eliminates the need of explicitly create an array before passing it, improving ease of use.
*/