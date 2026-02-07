using System;
public class Program
{
    public static void Main()
    {
        Console.Write("Enter first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number: ");
        int c = Convert.ToInt32(Console.ReadLine());
        int largest = (a > b && a > c) ? a : (b > c) ? b : c;
        Console.WriteLine($"Largest integer is: {largest}");
    }
}
