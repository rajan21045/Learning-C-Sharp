class Base
{
    public virtual void Test()
    {
        Console.WriteLine("HELLO");
    }
}

class subClass1 : Base
{
    public override void Test()
    {
        base.Test();
        Console.WriteLine("I am Inside dervied class");
    }
}

class BaseEx
{
    static void Main()
    {
        subClass1 obj = new subClass1();
        obj.Test();
    }
}