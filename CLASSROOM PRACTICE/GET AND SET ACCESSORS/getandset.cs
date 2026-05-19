using System;
class MyClass
{
    private int x;
    public void setx(int i)
    {
        x = i;
    }

    public int getx()
    {
        return x;
    }
}

class Program
{
    public static void Main()
    {
        MyClass obj = new MyClass();
        obj.setx(10);
        Console.WriteLine("Value of x is " + obj.getx());
    }
}