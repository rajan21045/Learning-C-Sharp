using System;
class Program
{
    static void Main()
    {

        /*
        C# Break
        You have already seen the break statement used in an earlier chapter of this tutorial. It was used to "jump out" of a switch statement.
        
        The break statement can also be used to jump out of a loop.
        This example jumps out of the loop when i is equal to 17:
        */
        for (int i = 0; i < 20; i++)
        {
            if (i == 17)
            {
                break; // When i is 17, the loop will terminate and the program will continue with the next statement after the loop.
            }
            Console.WriteLine(i);
        }

        Console.WriteLine();
        /*
        C# Continue
        The continue statement breaks one iteration (in the loop), if a specified condition occurs, and continues with the next iteration in the loop.
        This example skips the value of 4:
        */
        for (int i = 0; i < 20; i++)
        {
            if (i == 17)
            {
                continue; // When i is 17, the loop will skip the rest of the code in the current iteration and continue with the next iteration.
            }
            Console.WriteLine(i);
        }

        /*
        Break and Continue in While Loop
        You can also use break and continue in while loops:
        */
        Console.WriteLine();
        int j = 0;
        while (j < 10)
        {
            Console.WriteLine(j);
            j++;
            if (j == 4)
            {
                break;
            }
        }
    }
}