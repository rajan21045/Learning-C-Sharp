using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        //Filtering: Selecting elements which are even numbers
        var evennumber = numbers.Where(n => n%2==0);
        foreach(var item in evennumber)
        {
            Console.WriteLine(item);
        }

        //Projection: Transforming each element into a new form (squared values)
        var squaredNumbers = numbers.Select(n => n * n);
        foreach(var item in squaredNumbers)
        {
            Console.WriteLine(item);
        }

        //Sorting: Ordering elements in ascending order
        var sortedNumbers = numbers.OrderBy(n => n);
        foreach(var item in sortedNumbers)
        {
            Console.WriteLine(item);
        }
        var sortedNumbersDesc = numbers.OrderByDescending(n => n);
        foreach(var item in sortedNumbersDesc)
        {
            Console.WriteLine(item);
        }

        //Grouping: Grouping elements based on a condition (even and odd numbers)
        var groupedNumbers = numbers.GroupBy(n => n % 2 == 0 ? "Even" : "Odd");
        foreach(var group in groupedNumbers)
        {
            Console.WriteLine(group.Key);
            foreach(var item in group)
            {
                Console.WriteLine(item);
            }
        }

        //Joining: Joining two collections based on a common key
        List<string> names = new List<string> { "Alice", "Bob", "Charlie", "David" };
        var joinedData = numbers.Join(names, n => n, name => name.Length, (n, name) => new { Number = n, Name = name });
        foreach(var item in joinedData)
        {
            Console.WriteLine($"Number: {item.Number}, Name: {item.Name}");
        }
        
        //Aggregation: Performing aggregate operations like sum, average, count, etc.
        int sum = numbers.Sum();
        double average = numbers.Average();
        int count = numbers.Count();
        Console.WriteLine($"Sum: {sum}, Average: {average}, Count: {count}");
        
    }
}