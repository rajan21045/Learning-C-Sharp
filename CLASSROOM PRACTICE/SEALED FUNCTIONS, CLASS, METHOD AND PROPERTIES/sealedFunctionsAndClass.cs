using System;
sealed class Test
{
    public void message()
    {
        Console.WriteLine("Running From Sealed Class.");
    }
}

class Program
{
    static void Main()
    {
        Test obj = new Test();
        obj.message();
    }
}

