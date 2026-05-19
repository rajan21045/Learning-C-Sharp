// WAP to print even numbers from 0 to 100 using continue statement.
using System;
class Program
{
    static void Main()
    {
        for(int i=0; i<100; i++)
        {
            if (i % 2 != 0)
            {
                continue;
            }
            Console.WriteLine("i: "+ i);
        }
        Console.WriteLine("Loop Complete");
    }
}