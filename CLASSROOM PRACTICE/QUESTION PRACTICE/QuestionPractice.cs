/*
Q! WAP to check whether a given number is even or odd.
Q2. WAP to check whether a given number is positive, negative or zero.
Q3. WAP to input 3 numbers and find the smaller one. 

*/
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num % 2 == 0)
        {
            Console.WriteLine("{0} is Even", num);
        }
        else
        {
            Console.WriteLine("{0} is Odd", num);
        }

        // Q2 Check whether a given number is positive, negative or zero.
        if(num > 0)
        {
            if(num == 0)
            {
            Console.WriteLine("{0} is Zero", num);
            }
            else
            {
                Console.WriteLine("{0} is Positive", num);
            }
        }
        else
        {
            Console.WriteLine("{0} is Negative", num);
        }
       
        // Q3. WAP to input 3 numbers and find the smaller one.
        Console.WriteLine("Enter First numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second numbers: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Third numbers: ");
        int num3 = Convert.ToInt32(Console.ReadLine());

         if (num1 < num2)
        {
            if (num1 < num3)
            {
                Console.WriteLine("Smallest number is: " + num1);
            }
            else
            {
                Console.WriteLine("Smallest number is: " + num3);
            }
        }
        else
        {
            if (num2 < num3)
            {
                Console.WriteLine("Smallest number is: " + num2);
            }
            else
            {
                Console.WriteLine("Smallest number is: " + num3);
            }
        }

    }
}