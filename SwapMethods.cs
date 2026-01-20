using System;

class SwapMethods
{
    public static void Main()
    {
        int a = 5;
        int b = 4;

        Console.WriteLine($"{a} {b}");
        refSwap(ref a, ref b);
        Console.WriteLine($"{a} {b}");

        int x, y;
        Console.WriteLine($"{a} {b}");
        outSwap(a, b, out x, out y);
        Console.WriteLine($"{x} {y}");


    }
    static void refSwap(ref int x, ref int y)
    {
        x = x+y;
        y = x-y;
        x = x-y;
    }

    static void outSwap(int a, int b, out int x, out int y)
    {
       a = a+b;
       b = a-b;
       a = a-b;

        x = a;
        y = b;
    }
}