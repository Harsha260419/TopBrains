using System;

class LargestElement
{
    public static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        greatestElement(in a, in b, in c);

    }

    static void greatestElement(in int a, in int b, in int c)
    {
        if (a > b && a > c)
        {
            Console.WriteLine($"largest element: {a}");
        }
        else if (b > a && b > c)
        {
            Console.WriteLine($"largest element: {b}");
        }
        else
        {
            Console.WriteLine($"largest element: {c}");
        }
    }
}