using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

public class Program
{
    public static void Main()
    {
        List<Student> students = new List<Student>();
        Console.Write("Enter number of students: ");
        int count = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter details for student {i + 1} (Name Age Marks): ");
            string[] inputs = Console.ReadLine().Split(' ');
            Student s = new Student
            {
                Name = inputs[0],
                Age = Convert.ToInt32(inputs[1]),
                Marks = Convert.ToInt32(inputs[2])
            };
            students.Add(s);
        }

        var sortedData = students.OrderByDescending(s => s.Marks).ThenBy(s => s.Age);

        Console.WriteLine("Sorted Student Details:");
        foreach (var s in sortedData)
        {
            Console.WriteLine($"{s.Name} {s.Age} {s.Marks}");
        }
    }
}
