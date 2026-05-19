using System;
class Program
{
    static void Main()
{
    int[] a = { 1, 2, 3, 4, 5 };
    foreach (int i in a)
    {
        Console.WriteLine(i);
    }
    Console.ReadKey();
}
}