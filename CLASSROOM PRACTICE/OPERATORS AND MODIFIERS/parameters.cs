using System;
class Program
{
    static void Main()
    {
        Foo(8); // Call Foo With An Argument Of 8
        Foo1(21, "Rajan Poudel");

    }
    static void Foo(int x)
    {
        x = x + 1; // Increment x by 1
        Console.WriteLine("The Number After Increment Is: " + x); // Write the value of x to the screen
    }
    static void Foo1(int age, string name)
    {
        Console.WriteLine("My Name Is " + name + " And My Age Is " + age + " years old."); // Write the name and age to the screen
    }
}