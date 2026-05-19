// readonlyAndConstructor.cs

using System;
class Student
{
    public readonly int id; // readonly field
    public Student(int i)
    {
        id = i; // readonly field can be assigned in the constructor
    }
    public void display()
    {
        // id = 3;
        Console.WriteLine("ID: " + id);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student(1);
        s1.display();
        // s1.id = 2; // This will cause an error because id is a readonly field and cannot be assigned outside the constructor
    }
}