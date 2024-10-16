using System;
using System.Collections.Generic;

public class Teacher
{
    public string Name { get; set; }

    public Teacher(string name)
    {
        Name = name;
    }

    public void Teach(Student student)
    {
        Console.WriteLine($"{Name} is teaching {student.Name}.");
    }
}

public class Student
{
    public string Name { get; set; }

    public Student(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        Teacher teacher = new Teacher("Mr. Smith");
        Student student1 = new Student("Alice");
        Student student2 = new Student("Bob");

        teacher.Teach(student1); // Mr. Smith is teaching Alice.
        teacher.Teach(student2); // Mr. Smith is teaching Bob.
    }
}
