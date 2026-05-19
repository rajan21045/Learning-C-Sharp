// it is a value type with a set of related name constants often referred to as an enumerator list
enum month
{
    jan, feb, mar, apr, may
}
class Program
{
    static void Main()
    {
        Console.WriteLine("The value of jan in month enum is " + (int)month.jan);
        Console.WriteLine("The value of jan in month enum is " + (int)month.feb);
        Console.WriteLine("The value of jan in month enum is " + (int)month.mar);
        Console.WriteLine("The value of jan in month enum is " + (int)month.apr);
        Console.WriteLine("The value of jan in month enum is " + (int)month.may);
    }
}