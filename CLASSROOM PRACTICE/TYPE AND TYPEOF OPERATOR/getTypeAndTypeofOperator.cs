/*
Get type & type of operator

Get type is evaluated at runtime.
type of is evaluated at compile time.
*/


//Get Type & Type of Operator
using System;
public class Point
{
    public int x,y;
}

class Test
{
    static void Main()
    {
        Point p = new Point();
        Console.WriteLine(p.GetType().Name);
        Console.WriteLine(typeof(Point).Name);
        Console.WriteLine(p.x.GetType().Name);
        Console.WriteLine(p.y.GetType().FullName);
    }
}