//WAP to find even number upto 50 using do while loop

class Program
{
    static void Main()
    {
        int i = 1;
        do
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
                i++;
            }
        } while (i <= 50);
    }
}