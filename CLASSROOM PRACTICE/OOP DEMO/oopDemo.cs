using System;
namespace OOPDemo
{
    public class Student
    {
        private int id;
        private string name;
        public void setData(int i, string n)
        {
            id = i;
            name = n;
        }
        public void display()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Student s1 = new Student();
            s1.setData(1, "Rajan");
            s1.display();
            Console.WriteLine();
            Student s2 = new Student();
            s2.setData(2, "Abin");
            s2.display();
        }
    }
}