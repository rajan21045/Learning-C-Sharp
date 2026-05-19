using First;

namespace First
{
    class class1
    {
        public void show()
        {
            Console.WriteLine("Hello From Class .net");
        }
    }
}
namespace Second
{
        using First;
        class class2
        {
            public void display()
            {
                class1 obj = new class1(); // This will work because of the using directive for the First namespace
                obj.show(); // This will work because of the using directive for the First namespace
            }
        }
}

namespace Third
{
    class class3
    {
        public void test()
        {
            class1 obj = new class1();
            obj.show(); // This will cause an error because class1 is not accessible in this namespace without a using directive
        }
    }
}

class Program
{
    static void Main()
    {
        Second.class2 obj = new Second.class2();
        obj.display();
    }
}