//single Inheritance
using System;
class Animal
{
    public void Eat()
    {
        Console.WriteLine("Animals eat food");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Dogs bark");
    }
}


class Program
{
    static void Main()
    {
        Dog dog = new Dog();
        dog.Bark();
        dog.Eat();
    }
}