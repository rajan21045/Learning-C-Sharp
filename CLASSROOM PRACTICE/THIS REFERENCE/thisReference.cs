// the this reference
using System;
class Student
{
    public int id, age;
    public string name, subject;
    public Student(int id, String name, int age, string subject)
    {
        this.id = id;
        this.name = name;
        this.subject = subject;
        this.age = age;
    }
    public void showInfo()
    {
        Console.WriteLine(id + " " + name + " " + age + " " + subject);
    }
}

class studentDetails
{
   public static void Main(string[] args)
    {
        Student s1 = new Student(1, "Rajan", 20, "C Sharp");
        s1.showInfo();
    }
}