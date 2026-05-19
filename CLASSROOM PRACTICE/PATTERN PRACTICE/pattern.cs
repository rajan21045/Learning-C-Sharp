using System;
class Program
{
    static void Main()
    {
        for(int i=0; i<10; i++)
        {
            for(int j =i; j<10; j++)
            {
                Console.Write("* ");
            }
            // Console.ReadKey();
            Console.WriteLine();
        }
    }
}