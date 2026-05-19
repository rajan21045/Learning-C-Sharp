using System;
class User
{
    static User()
    {
        Console.WriteLine("This is Static Constructor");
    }
    public User()
    {
        Console.WriteLine("I am a Default Constructor");
    }
}
    class Program
    {
        static void Main()
        {
            User obj = new User();
            User obj2 = new User();
            Console.WriteLine("\nPress Enter To Exit");
            Console.ReadKey();
        }
    }
