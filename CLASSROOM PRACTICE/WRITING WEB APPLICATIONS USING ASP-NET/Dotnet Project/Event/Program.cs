/*
 Events are user actions such as Key press, clicks, mouse movements etc or some occurrence such as system generated notifications.
    -   It return void & take two parameters.
 */


using System;
public delegate void DelEventHandler();

class Program
{
    public static event DelEventHandler add;
    static void Australia()
    {
        Console.WriteLine("Australia");
    }

    static void Canada()
    {
        Console.WriteLine("Canada");
    }

    static void Nepal()
    {
        Console.WriteLine("Nepal");
    }

    static void Main(string[] args)
    {
        add += new DelEventHandler(Australia);
        add += new DelEventHandler(Canada);
        add += new DelEventHandler(Nepal);
        add.Invoke();

    }
}