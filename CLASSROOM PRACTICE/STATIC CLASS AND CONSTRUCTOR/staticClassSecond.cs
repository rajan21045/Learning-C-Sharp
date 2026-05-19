static class Author
{
    public static string Fname = "Rajan";
    public static string Lname = "Poudel";
    public static int Tno = 39;
    public static void details()
    {
        Console.WriteLine("The Details of the Author are:");
    } 
}

public class GFG
{
    static public void Main()
    {
        Author.details();
        Console.WriteLine("First Name: " + Author.Fname);
        Console.ReadKey();
        Console.WriteLine("Last Name: " + Author.Lname);
        Console.ReadKey();
        Console.WriteLine("Total Number: " + Author.Tno);
        Console.ReadKey();
    }
}