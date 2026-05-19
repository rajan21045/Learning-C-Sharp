class Base
{
    public virtual void Test()
    {
        Console.WriteLine("Extra");
    }
}
class subClass1 : Base
{
    public sealed override void Test()
    {
        Console.WriteLine("Hello");
    }
}
// class subClass2 : subClass1
// {
//     public override void Test()
//     {
//         Console.WriteLine("Hello Bro");
//     }
// }

class Program
{
    static void Main()
    {
        subClass1 obj = new subClass1();
        obj.Test();

        // subClass2 obj1 = new subClass2();
        // obj1.Test();
    }
}