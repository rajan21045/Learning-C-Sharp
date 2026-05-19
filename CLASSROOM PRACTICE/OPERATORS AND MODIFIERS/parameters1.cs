using System;
namespace Parameters
{
    class Program
    {
        static void Main()
        {
            int x = 8;
            int y = 21;
            Console.WriteLine("The Number Is: " + x); // Write the value of x to the screen
            Foo(x); // Call Foo With An Argument Of 8
            Foo1(ref y); 
            Console.WriteLine("The Number Is: " + y); // Write the value of y to the screen
        }
        static void Foo(int x)
        {
            x = x + 1; // Increment x by 1
            Console.WriteLine("The Number After Increment Is: " + x); // Write the value of x to the screen
        }

        static void Foo1(ref int y)
        {
            y = y + 1; // Increment y by 1
            Console.WriteLine("The Number Is: " + y); // Write the value of y to the screen
        }
    }
}