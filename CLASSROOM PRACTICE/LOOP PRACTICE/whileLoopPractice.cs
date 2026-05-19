//WAP to find odd number upto 50 using while loop

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Odd Number Are: ");
        int i=1;
        while(i<=50)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}