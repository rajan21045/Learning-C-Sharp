//multilevel-inheritance
using System;
class Vechile
{
    public void FourWheeler()
    {
        Console.WriteLine("Vechile has 4 wheelers");
    }
}
class Bike : Vechile
{
    public void TwoWheeler()
    {
        Console.WriteLine("Bike has 2 wheelers");
    }
}

class Tus : Bike
{
    public void Wheeler()
    {
        Console.WriteLine("Tus has 2 wheelers");
    }
}

class Program
{
    static void Main()
    {
        Tus tus = new Tus();
        tus.Wheeler();
        tus.TwoWheeler();
        tus.FourWheeler();

    }
}