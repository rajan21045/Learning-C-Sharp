using System;
class Shape
{
    public void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public void DisplayingCircle()
    {
        Console.WriteLine("Displaying a circle");
    }
}

class Rectangle : Shape
{
    public void DisplayingRectangle()
    {
        Console.WriteLine("Displaying a rectangle");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine();
        Rectangle rec = new Rectangle();
        rec.DisplayingRectangle();
        rec.Draw();

        Console.WriteLine();
        Circle cir = new Circle();
        cir.DisplayingCircle();
        cir.Draw();

    }
}