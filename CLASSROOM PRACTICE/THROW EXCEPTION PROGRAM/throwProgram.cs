using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter Your Age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age < 18)
        {
            throw new ArithmeticException("You are not eligible to vote");
        }else
        {
            Console.WriteLine("You are eligible to vote");
        }
    }
}