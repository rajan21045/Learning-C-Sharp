//Delegates Mapping With Instance & Static Method
using System;
class A
{
    public void InstanceMethod()
    {
        Console.WriteLine("Instance Method");
    }

    public static void StaticMethod()
    {
        Console.WriteLine("Static Method");
    }
}


class Program
{
    delegate void Del();
    static void Main(string[] args)
    {
        A objA = new A();
        Del d = objA.InstanceMethod;
        d();
        d = A.StaticMethod;
        d();
        Console.ReadKey();
    }
}