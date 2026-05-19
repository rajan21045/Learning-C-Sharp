class check
{
    public int a
    {
        get; set;
    }
    public int sum
    {
        get { return a + b; }
    }
}
class Program
{
    public static void Main()
    {
        check c = new check();
        c.a = 10;
        c.b = 20;
        Console.WriteLine("Sum of a and b is " + c.sum);
        Console.ReadKey();
    }
}