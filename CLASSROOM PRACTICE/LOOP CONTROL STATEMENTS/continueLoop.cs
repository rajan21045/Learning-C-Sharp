using System;
class Program
{
    static void Main()
    {
        for(int i=0; i<100; i++)
        {
            if (i == 10)
            {
                continue;
            }
            Console.WriteLine("i: "+ i);
        }
        Console.WriteLine("Loop Complete");
    }
}