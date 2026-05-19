using System;
class Program
{
    static int Add(int a, int b)
    {
        return a+b;
    }
    static int Add(int a, int b,int c)
    {
        return a+b+c;
    }
    static double Add(double a, double b){
        return a+b;
    }
    static void Main()
    {
        Console.WriteLine("Sum of Two Number Is " +Add(5,10));
        Console.WriteLine("Sum of Three Number Is " +Add(5,10, 45));
        Console.WriteLine("Sum of Two Floats Number Is " +Add(5.23,10.123));
    }
}