/*
 Lamba expression
- they are used like anonymous function, with the difference that in lambda expressions you don't need to specify the type of the value that you input.
- The => is the lambda operator.
- Are of two types:
    a) Expression lambda
    Syntax: input =>expression;
    b) statement lambda
    syntax: input =>{statements};
E.g:
 */

using System.Diagnostics;

class Program
{
    static int Test1() => 5;
    static int Test2(int x) => x+10;

    static void Main()
    {
        int x = Test1();
        int rez = Test2(x);
        Console.WriteLine(rez);

        /*
         Statement Lanmba
         */
        delegate void ModtifyInt(int input);
        ModtifyInt addOne = x =>
        {
            int r = x + 1;
            Console.WriteLine(r);
        };
    }
}