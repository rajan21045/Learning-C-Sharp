/*
Static class
    static class{
        static data members
        static methods
    }
*/
class MyCollege
{
    public static string CollegeName;
    public static string CollegeAddress;

    static MyCollege()
    {
        CollegeName = "Lumbini ICT College";
        CollegeAddress = "Gaindakot-04, Nawalparasi";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("College Name: " + MyCollege.CollegeName);
        Console.ReadKey();
        Console.WriteLine("College Address: " + MyCollege.CollegeAddress);
        Console.ReadKey();
    }
}
