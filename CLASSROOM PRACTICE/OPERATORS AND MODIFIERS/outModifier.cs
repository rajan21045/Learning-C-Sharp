using System;
class OutModifier
{
    static void Main()
    {
        int x, y;
        Pass(10, 20, out x, out y); // Call Pass With An Argument Of 10 And 20
        Console.WriteLine("The Value Of x Is: " + x); // Write the value of x to the screen
        Console.WriteLine("The Value Of y Is: " + y); // Write the value of y to the screen
    }
    static void Pass(int a, int b, out int x, out int y)
    {
        x = a;
        y = b;
    }
}