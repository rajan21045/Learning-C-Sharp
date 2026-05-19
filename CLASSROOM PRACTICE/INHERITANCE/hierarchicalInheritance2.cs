class Polygon
{
    public int dim1, dim2;
    public void ReadDimensions(int dim1, int dim2)
    {
        this.dim1 = dim1;
        this.dim2 = dim2;
    }
}

class Rectangle : Polygon
{
    public void AreaRec()
    {
        Console.WriteLine("Area of rectangle: " + (dim1 * dim2));
    }
}

class Triangle : Polygon
{
    public void AreaTri()
    {
        double area = 0.5 * dim1 * dim2;
        Console.WriteLine("Area of triangle: " + area);
    }
}

class Hier
{
    static void Main()
    {
        Rectangle rec = new Rectangle();
        rec.ReadDimensions(10, 5);
        rec.AreaRec();

        Triangle tri = new Triangle();
        tri.ReadDimensions(10,7);
        tri.AreaTri();
    }
}