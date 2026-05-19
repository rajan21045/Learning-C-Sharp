using System;
using System.Collections.Generic;

class Test<T>
{
    T[] t = new T[5];
    int count = 0;

    public void addItem(T item)
    {
        if (count < 5)
        {
            t[count] = item;
            count++;
        }
        else
        {
            Console.WriteLine("Overflow Exists");
        }
    }

    public void displayItem()
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine("Item at index {0} is {1}", i, t[i]);
        }
    }
}

class GenericEx
{
    static void Main()
    {
        Test<int> obj = new Test<int>();
        obj.addItem(10);
        obj.addItem(20);
        obj.addItem(30);
        obj.addItem(40);
        obj.addItem(50);
        // obj.addItem(60); // Overflow Exists
        obj.displayItem();
        Console.ReadKey();
    }
}