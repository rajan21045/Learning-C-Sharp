using System;
delegate int MathOperation(int a, int b);
delegate int MathOperation2(int a, int b);

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main(string[] args)
    {
        //1. Named method
        MathOperation operation = Add;
        int result = operation(5, 10);
        /*
        Here:
        MathOperation → Add()
        Add() has a name, so it is a named method.
        */
        Console.WriteLine("The sum is: " + result);

        //2. Anonymous method
        //An anonymous method has no method name. You create it using the delegate keyword:
        MathOperation2 operation2 = delegate (int a, int b)
        {
            return a + b;
        };
        Console.WriteLine(operation2(10, 20));
        /*
        Output: 30
        Notice that we don't have:
        static int Add(...)
        Instead, the method is directly assigned to the delegate:
        MathOperation operation = delegate (int a, int b)
        {
        return a + b;
        };
        */


        /*
        3. Named vs Anonymous
        ------------------------------------------------------------------- 
        | Named Method           | Anonymous Method                       |
        | ---------------------- | -------------------------------------- |
        | Has a method name      | No method name                         |
        | Can be reused easily   | Usually used for a specific purpose    |
        | Defined separately     | Defined where the delegate is assigned |
        | Easier for large logic | Convenient for small logic             |
        ------------------------------------------------------------------- 
        */

        // 4. Anonymous methods vs Lambda expressions

        // In modern C#, anonymous methods are often replaced by lambda expressions.

        // Anonymous method:

        // MathOperation operation = delegate(int a, int b)
        // {
        //     return a + b;
        // };
        // Lambda:
        MathOperation operation = (a, b) => a + b;
    }
}