abstract class test1
{
    public int add(int i, int j)
    {
        return i + j;
    }
    public abstract int mul(int i, int j);
}

class test2 : test1
{
    public override int mul(int i, int j)
    {
        return i*j;
    }
}

class test3 : test1
{
    public override int mul(int i, int j)
    {
        return i-j;
    }
}

class Program
{
    static void Main()
    {
        test2 obj = new test2();
        int r = obj.mul(5, 10);

        test3 obj1 = new test3();
        int r1 = obj1.mul(5, 10);
        int c = obj1.add(5, 10);

        Console.WriteLine("Result: " + r);
        Console.WriteLine("Result: " + r1);
        Console.WriteLine("Result: " + c);
    }
}