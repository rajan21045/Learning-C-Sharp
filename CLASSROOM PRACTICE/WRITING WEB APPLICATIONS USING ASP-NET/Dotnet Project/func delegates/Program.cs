//func delegates
/*
 it is a generic delegate included in the System namespace having zero or more input parameters and one output parameters.
e.g. public delegate TResult Func<int T, out TResult> <T arg>;
 */

class Program
{
    static int Sum(int x, int y)
    {
        return x + y;
    }

    static void Main(string[] args)
    {
        Func<int, int, int> add = Sum;
        int r = add(10, 15);
        Console.WriteLine(r);
    }
}