// WAP to take 3 numbers as input and find the greatest number among them using nested if statements.

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter First numbers: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second numbers: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Third numbers: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        if(num1 > num2)
        {
            if(num1 > num3)
            {
                Console.WriteLine("The Greatest Number Is: "+ num1);
            }
            else
            {
                Console.WriteLine("The Greatest Number Is: "+ num3);
            }
        }
        else
        {
            if(num2> num3)
            {
                Console.WriteLine("The Greatest Number Is: "+ num2);
            }else
            {
                Console.WriteLine("The Greatest Number Is: "+ num3);
            }
        }
    }
}