using System;

class Program
{
    static void Main()
    {
        //WAP To Print Prime Numbers Between 1 To 50 using for loop
        Console.WriteLine("Prime Numbers Between 1 To 50:");
        int num,i;
        for(num= 2; num<=50; num++)
        {
            bool isPrime = true;
            for(i=2; i<num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine(num);
            }
        }
    }
}