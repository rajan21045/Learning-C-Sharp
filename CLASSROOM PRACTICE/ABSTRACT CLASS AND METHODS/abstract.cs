abstract class MCN
{
    public int add(int a, int b)
    {
        return a+b;
    }
}

class MCN1 : MCN
{
    public int mul(int a, int b)
    {
        return (a*b);
    }
}


class Test
{
    static void Main()
    {
        MCN1 obj = new MCN1();
        int r= obj.add(5, 10);
        Console.WriteLine("Result: "+ r);
    }
}