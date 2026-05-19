using System;
class ConsDes
{
    public ConsDes(string msg)
    {
        Console.WriteLine(msg);
    }
    public void Test()
    {
        Console.WriteLine("This is simple Method");
    }
    ~ConsDes()
    {
        Console.WriteLine("This is Destructor");
        Console.ReadKey();
    }
}
    class Program
    {
        static void Main()
        {
            string m = "Rajan";
            ConsDes obj = new ConsDes(m);
            obj.Test();
        }
    }
