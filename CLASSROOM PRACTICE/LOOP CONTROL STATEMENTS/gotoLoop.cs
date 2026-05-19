using System;
class Program
{
    static void Main()
    {
        int i = 1;
        startLoop:
        if(i <=10){
        Console.WriteLine("i: " + i);
        i++;
        goto startLoop;
        }
        Console.WriteLine("Loop Complete");
    }
}