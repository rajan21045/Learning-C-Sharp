using System;

interface IShape
{
    double GetArea();
}

interface IColor
{
    string GetColor();
}

class Rectangle : IShape, IColor
{
    private double length;
    private double breadth;
    private string color;

    public Rectangle(double length, double breadth, string color)
    {
        this.length = length;
        this.breadth = breadth;
        this.color = color;
    }

    public double GetArea()
    {
        return length * breadth;
    }

    public string GetColor()
    {
        return color;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle(5, 10, "Blue");

        Console.WriteLine("Area: " + rect.GetArea());
        Console.WriteLine("Color: " + rect.GetColor());
    }
}