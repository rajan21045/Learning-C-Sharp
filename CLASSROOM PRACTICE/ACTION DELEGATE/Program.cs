//Action Delegate
/*
    - Same as Func Delegate except that the Action delegate doesn't return a value.
    - Can Take Upto 16 Input parameters of different types.
*/

//e.g.

using System;
public delegate void Print(int val);
class Program
{ 
static void ConsolePrint(int i)
{
    Console.WriteLine(i);
}
    static void Main(string[] args)
    {
        Action<int> prnt = ConsolePrint;
        prnt(10);
    }
}