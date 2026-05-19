// use to access field of base class from dervied class
using System;
public class Animal
{
    public string color = "White";
}

public class Dog: Animal
{
    string color = "Black";
    public void showColor()
    {
        Console.WriteLine(base.color);
        Console.WriteLine(color);
    }
}

public class TestBase
{
    static void Main()
    {
        Dog d = new Dog();
        d.showColor();
    }
}