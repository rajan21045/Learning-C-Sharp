/* 
A delegate is a type that safely encapsulates a method, similar to a function pointer in C and C++. 
Unlike C function pointers, delegates are object-oriented, type safe, and secure.
*/
using System;
public delegate int mathOperation(int a, int b, int c);
public delegate void stringMessage(string message);

public class Program
{
    static int Add(int d, int e, int f)
    {
        return (d+e+f);
    }
    static void displayMessage(string Message)
    {
        Console.WriteLine("Hello, I Welcome You.");
        Console.WriteLine(Message);
    }
    static void Main(string[] args)
    {
        mathOperation Operation = Add;
        //A MathOperation can reference any method that takes two ints and returns an int.
        int result = Operation(1, 2, 3);
        Console.WriteLine(result);

        stringMessage mess = displayMessage;
        mess("Hello, I Am Rajan Poudel. I Am Writing This Message To Welcome You.");
    }
}