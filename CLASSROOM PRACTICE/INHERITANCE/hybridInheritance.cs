interface Animal
{
    void Fly();
    
}

interface Dog
{
    void Bark();
}

class Bird : Animal, Dog
{
   public void makeSound()
    {
        Console.WriteLine("Hello, Bird Can Fly.");
    }

   public void Fly()
    {
        Console.WriteLine("Hello");
    }

  public  void Bark()
    {
        Console.WriteLine("Hello");
    }
}

class Eagle : Bird
{
   public void fly()
    {
        Console.WriteLine("Eagle Can fly.");
    }
}

class Program
{
    static void Main()
    {
        Eagle obj = new Eagle();
        obj.fly();
        obj.Bark();
        obj.Fly();
        obj.makeSound();
    }
}