using System;

class Employee
{
    public string name;
    public int age;
    public double salary;

    // Default Constructor
    public Employee()
    {
        name = "Unknown";
        age = 0;
        salary = 0.0;
    }

    // Constructor with 2 parameters
    public Employee(string name, int age)
    {
        this.name = name;
        this.age = age;
        this.salary = 0.0;
    }

    // Constructor with 3 parameters
    public Employee(string name, int age, double salary)
    {
        this.name = name;
        this.age = age;
        this.salary = salary;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Age: {age}, Salary: {salary}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp1 = new();
        Employee emp2 = new("Rajan", 21);
        Employee emp3 = new("Rajan", 21, 50000.324);

        emp1.Display();
        emp2.Display();
        emp3.Display();
    }
}