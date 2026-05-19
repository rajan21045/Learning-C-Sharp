namespace Outer
{
    class class1
    {
        public void show()
        {
            Console.WriteLine("Inside class1");
        }
    }

    namespace Inner
    {
        class class2
        {
            public void display()
            {
                class1 obj = new class1();
                obj.show();
            }
        }
    }
}